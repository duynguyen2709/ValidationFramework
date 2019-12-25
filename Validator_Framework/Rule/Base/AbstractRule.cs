using System;
using Validation_Framework.Result;

namespace Validation_Framework.Rule
{
    public abstract class AbstractRule : Attribute
    {
        protected string errorMessage;

        protected AbstractRule(string errorMessage)
        {
            this.errorMessage = errorMessage;
            AddSupportType();
        }

        private AbstractRule() { }

        public ValidationResult Validate(dynamic target)
        {
            ValidationResult validationResult;
            try
            {
                // check type support
                if (RuleContainer.GetInstance().CheckRuleSupportingType(GetType(), target.GetType()) == false)
                {
                    validationResult = new ValidationResult(false, string.Format("Rule {0} không hỗ trợ cho kiểu dữ liệu {1}", GetType(), target.GetType()));
                    return validationResult;
                }

                if (CheckValid(target) == false)
                {
                    validationResult = new ValidationResult(false, errorMessage);
                }
                else
                {
                    validationResult = new ValidationResult(true, "");
                }
            }
            catch (Exception e)
            {
                validationResult = new ValidationResult(false, e.Message);
            }

            return validationResult;
        }

        protected abstract bool CheckValid(dynamic target);
        protected abstract void AddSupportType();
    }
}
