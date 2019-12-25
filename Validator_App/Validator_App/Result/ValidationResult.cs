namespace Validation_App.Result
{
    public class ValidationResult
    {
        private ValidationResult()
        { }

        public ValidationResult(bool isValid, string errorMessage)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }

        public bool IsValid { get; }
        public string ErrorMessage { get; }
    }
}
