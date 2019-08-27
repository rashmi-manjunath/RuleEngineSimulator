using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineSimulator
{
    public interface IDataType
    {
        bool ValidateExpression(string value1, string value2, string condition);
    }
}
