using System;
using System.Collections.Generic;

namespace Validation_App.Rule
{
    public sealed class RuleContainer
    {
        private static RuleContainer instance = null;

        private readonly Dictionary<Type, List<Type>> ruleSupportingMap = new Dictionary<Type, List<Type>>();

        private RuleContainer() { }

        public static RuleContainer GetInstance()
        {
            if (instance == null)
            {
                instance = new RuleContainer();
            }

            return instance;
        }

        public void AddSupportType(Type ruleType, List<Type> supportType)
        {
            if (!ruleSupportingMap.ContainsKey(ruleType))
            {
                ruleSupportingMap.Add(ruleType, supportType);
            }
        }

        public bool CheckRuleSupportingType(Type rule, Type target)
        {
            if (!ruleSupportingMap.ContainsKey(rule))
            {
                return false;
            }

            List<Type> values = ruleSupportingMap[rule];
            return values.Contains(target);
        }
    }
}
