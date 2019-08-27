using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineSimulator
{
    public class RuleValidation
    {
        private readonly IDataType _valueTypeService;
        public RuleValidation(IDataType valueType)
        {
            _valueTypeService = valueType;
        }

        /// <summary>
        /// Validare Rule
        /// </summary>
        /// <param name="value1">Value1</param>
        /// <param name="value2">Value2</param>
        /// <param name="relation">Rule Relation</param>
        /// <returns></returns>
        public bool ValidateRule(string value1, string value2, string relation)
        {
            return _valueTypeService.ValidateExpression(value1, value2, relation);
        }

    }
}
