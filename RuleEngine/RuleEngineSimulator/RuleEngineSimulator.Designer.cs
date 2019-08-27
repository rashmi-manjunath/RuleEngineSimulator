namespace RuleEngineSimulator
{
    partial class RuleEngineSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upload = new System.Windows.Forms.Button();
            this.uploadedFilePath = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addRule = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.Condition = new System.Windows.Forms.ComboBox();
            this.valueTypeSelection = new System.Windows.Forms.ComboBox();
            this.signalID = new System.Windows.Forms.TextBox();
            this.listRule = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Results = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.GetData = new System.Windows.Forms.Button();
            this.ApplyRule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.setRule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.SystemColors.Highlight;
            this.upload.Location = new System.Drawing.Point(23, 32);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(117, 39);
            this.upload.TabIndex = 0;
            this.upload.Text = "Upload File";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // uploadedFilePath
            // 
            this.uploadedFilePath.AutoSize = true;
            this.uploadedFilePath.Location = new System.Drawing.Point(191, 43);
            this.uploadedFilePath.Name = "uploadedFilePath";
            this.uploadedFilePath.Size = new System.Drawing.Size(0, 17);
            this.uploadedFilePath.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upload);
            this.groupBox1.Controls.Add(this.uploadedFilePath);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Section";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addRule);
            this.groupBox2.Controls.Add(this.value);
            this.groupBox2.Controls.Add(this.Condition);
            this.groupBox2.Controls.Add(this.valueTypeSelection);
            this.groupBox2.Controls.Add(this.signalID);
            this.groupBox2.Location = new System.Drawing.Point(21, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 248);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rules Section";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Signal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Value Type";
            // 
            // addRule
            // 
            this.addRule.Location = new System.Drawing.Point(23, 165);
            this.addRule.Name = "addRule";
            this.addRule.Size = new System.Drawing.Size(494, 44);
            this.addRule.TabIndex = 5;
            this.addRule.Text = "Add Rule";
            this.addRule.UseVisualStyleBackColor = true;
            this.addRule.Click += new System.EventHandler(this.addRule_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(326, 125);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(133, 22);
            this.value.TabIndex = 3;
            // 
            // Condition
            // 
            this.Condition.Location = new System.Drawing.Point(170, 125);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(121, 24);
            this.Condition.TabIndex = 10;
            // 
            // valueTypeSelection
            // 
            this.valueTypeSelection.FormattingEnabled = true;
            this.valueTypeSelection.Location = new System.Drawing.Point(19, 58);
            this.valueTypeSelection.Name = "valueTypeSelection";
            this.valueTypeSelection.Size = new System.Drawing.Size(121, 24);
            this.valueTypeSelection.TabIndex = 1;
            this.valueTypeSelection.SelectedIndexChanged += new System.EventHandler(this.valueTypeSelection_SelectedIndexChanged);
            // 
            // signalID
            // 
            this.signalID.Location = new System.Drawing.Point(23, 127);
            this.signalID.Name = "signalID";
            this.signalID.Size = new System.Drawing.Size(121, 22);
            this.signalID.TabIndex = 0;
            // 
            // listRule
            // 
            this.listRule.FormattingEnabled = true;
            this.listRule.ItemHeight = 16;
            this.listRule.Location = new System.Drawing.Point(21, 410);
            this.listRule.Name = "listRule";
            this.listRule.Size = new System.Drawing.Size(605, 100);
            this.listRule.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(674, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 380);
            this.dataGridView1.TabIndex = 5;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(671, 110);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(55, 17);
            this.Results.TabIndex = 6;
            this.Results.Text = "Results";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(21, 516);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(157, 36);
            this.remove.TabIndex = 7;
            this.remove.Text = "RemoveRule";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // GetData
            // 
            this.GetData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GetData.Location = new System.Drawing.Point(674, 41);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(257, 40);
            this.GetData.TabIndex = 8;
            this.GetData.Text = "Get Data Stream";
            this.GetData.UseVisualStyleBackColor = false;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // ApplyRule
            // 
            this.ApplyRule.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ApplyRule.Location = new System.Drawing.Point(965, 41);
            this.ApplyRule.Name = "ApplyRule";
            this.ApplyRule.Size = new System.Drawing.Size(234, 40);
            this.ApplyRule.TabIndex = 9;
            this.ApplyRule.Text = "Apply Rule";
            this.ApplyRule.UseVisualStyleBackColor = false;
            this.ApplyRule.Click += new System.EventHandler(this.ApplyRule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Count : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 11;
            // 
            // setRule
            // 
            this.setRule.Location = new System.Drawing.Point(485, 515);
            this.setRule.Name = "setRule";
            this.setRule.Size = new System.Drawing.Size(141, 37);
            this.setRule.TabIndex = 12;
            this.setRule.Text = "Set Rule";
            this.setRule.UseVisualStyleBackColor = true;
            this.setRule.Click += new System.EventHandler(this.setRule_Click);
            // 
            // RuleEngineSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 565);
            this.Controls.Add(this.setRule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApplyRule);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listRule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RuleEngineSimulator";
            this.Text = "Rule Engine Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label uploadedFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.ComboBox Condition;
        private System.Windows.Forms.ComboBox valueTypeSelection;
        private System.Windows.Forms.TextBox signalID;
        private System.Windows.Forms.Button addRule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listRule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.Button ApplyRule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setRule;
    }
}

