using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineSimulator
{
    public class StringDataType : IDataType
    {
        public bool ValidateExpression(string value1, string value2, string relation)
        {
            switch (relation)
            {
                case Constants.IsEqualTo:
                    return string.Equals(value1, value2);
                case Constants.IsNotEqualTo:
                    return !string.Equals(value1, value2);
                case Constants.Contain:
                    return value1.Contains(value2);
                default:
                    return false;
            }
        }
    }
}
