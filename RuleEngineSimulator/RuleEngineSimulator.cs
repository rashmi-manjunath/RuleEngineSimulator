using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = RuleEngineSimulator.Rule;


namespace RuleEngineSimulator
{
    public partial class RuleEngineSimulator : Form
    {
        private string _ruleFilePath = "DataRules.json";

        /// <summary>
        /// Constructor.
        /// </summary>
        public RuleEngineSimulator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            addValueType();
            dateTimePicker1.Visible = false;
            value.Visible = true;
            if (File.Exists(_ruleFilePath))
                LoadRules();
            else
                CreateFile();
        }
        /// <summary>
        /// Add items to the value types.
        /// </summary>
        private void addValueType()
        {
            valueTypeSelection.Items.Add(Constants.String);
            valueTypeSelection.Items.Add(Constants.Integer);
            valueTypeSelection.Items.Add(Constants.Date);
        }
        /// <summary>
        /// Creates Empty file.
        /// </summary>
        private void CreateFile()
        {
            try
            {
                using (var writer = new StreamWriter(_ruleFilePath))
                {
                    writer.Write("[]");
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Upload json file data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadedFilePath.Text = openFileDialog.FileName.ToString();
            }
        }
      
        /// <summary>
        /// Adds the newly defined rule to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRule_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(signalID.Text) && valueTypeSelection.SelectedIndex == -1 &&
                          Condition.SelectedIndex == -1)
                    throw new Exception("Please Enter Values");

                if (valueTypeSelection.SelectedIndex == 1 && !int.TryParse(value.Text, out var result))
                    throw new Exception("Enetr Valid Type for Interger");


                foreach (var item in listRule.Items)
                {
                    var rule = (Rule)item;
                    if (rule.SignalID == signalID.Text && rule.ValueTYpe == valueTypeSelection.SelectedItem.ToString())
                        throw new Exception("Rule Already Added");
                }

                var i = listRule.Items.Add(new Rule()
                {
                    SignalID = signalID.Text,
                    ValueTYpe = valueTypeSelection.SelectedItem.ToString(),
                    RuleRelation = Condition.SelectedItem.ToString(),
                    value = valueTypeSelection.SelectedIndex == 2 ? dateTimePicker1.Value.ToString() : value.Text
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Binds conditions based on value type change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valueTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Condition.Items.Clear();

            if (valueTypeSelection.SelectedIndex == 2)
            {
                value.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                value.Visible = true;
                dateTimePicker1.Visible = false;
            }
            Condition.Items.Add(Constants.IsEqualTo);
            Condition.Items.Add(Constants.IsNotEqualTo);
            switch (valueTypeSelection.SelectedIndex)
            {
                case 0:
                    Condition.Items.Add(Constants.Contain);
                    break;
                default:
                    Condition.Items.Add(Constants.IsGreaterThan);
                    Condition.Items.Add(Constants.IsLessThan);
                    break;
            }
            Condition.SelectedIndex = 0;
        }
        /// <summary>
        /// Gets the stream of uploaded data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetData_Click(object sender, EventArgs e)
        {
            if (!File.Exists(uploadedFilePath.Text))
            {
                MessageBox.Show("Choose valid File", "File Not exist!");
                return;
            }
            var results = GetDataStreams(uploadedFilePath.Text);
            dataGridView1.DataSource = results;
            label6.Text = results?.Count.ToString();
        }

        /// <summary>
        /// Gets data stream.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public List<DataStream> GetDataStreams(string file)
        {
            using (var reader = new StreamReader(file))
            {
                string jsonString = reader.ReadToEnd();
                reader.Close();
                var result = JsonConvert.DeserializeObject<List<DataStream>>(jsonString);
                return result;
            }
        }
       

        private void remove_Click(object sender, EventArgs e)
        {
            if (listRule.SelectedIndex != -1)
            {
                listRule.Items.RemoveAt(listRule.SelectedIndex);
                listRule.ForeColor = Color.Orange;
            }

            else
                MessageBox.Show("Please Select Rule to remove");
        }

        private void setRule_Click(object sender, EventArgs e)
        {
            try
            {
                List<Rule> ruleList = new List<Rule>();

                foreach (var item in listRule.Items)
                {
                    ruleList.Add((Rule)item);
                }

                SetRules(ruleList, _ruleFilePath);

                LoadRules();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetRules(List<Rule> rules, string filePath)
        {
            var jsonCfg = JsonConvert.SerializeObject(rules);
            using (var writer = new StreamWriter(filePath))
            {
                writer.Write(jsonCfg);
                writer.Close();
            }
        }
        private void LoadRules()
        {
            try
            {
                var rules = GetAllRules(_ruleFilePath);
                listRule.Items.Clear();
                listRule.ForeColor = Color.Green;
                foreach (var rule in rules)
                {
                    listRule.Items.Add(rule);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplyRule_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(_ruleFilePath))
                    return;
                var streamData = GetDataStreams(uploadedFilePath.Text);
                var ruleData = GetAllRules(_ruleFilePath);

                streamData = ApplyRules(streamData, ruleData).ToList();
                dataGridView1.DataSource = streamData;
                label6.Text = streamData?.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Rule> GetAllRules(string filePath)
        {
            List<Rule> rules = new List<Rule>();
            var reader = new StreamReader(filePath);
            string jsonString = reader.ReadToEnd();
            rules = JsonConvert.DeserializeObject<List<Rule>>(jsonString);
            return rules;
        }

        /// <summary>
        /// Apply Rules on Stream data.
        /// </summary>
        /// <param name="stream">List of Stream Data</param>
        /// <param name="rules">List of Rules</param>
        /// <returns>List of Stream data which violates rules</returns>
        public IEnumerable<DataStream> ApplyRules(List<DataStream> streamData, List<Rule> rules)
        {
            foreach (var stream in streamData)
            {
                var rule = rules.FirstOrDefault(item => item.SignalID == stream.signal && item.ValueTYpe == stream.Value_Type);
                if (rule != null)
                {
                    var validdationService = GetRuleValidation(rule.ValueTYpe);
                    if (!validdationService.ValidateRule(stream.value, rule.value, rule.RuleRelation))
                        yield return stream;
                }
            }
        }
        private RuleValidation GetRuleValidation(string valueType)
        {
            switch (valueType)
            {
                case Constants.Integer:
                    return new RuleValidation(new IntergerDataType());
                case Constants.Date:
                    return new RuleValidation(new DateDataType());
                default:
                    return new RuleValidation(new StringDataType());

            }
        }
    }


}
