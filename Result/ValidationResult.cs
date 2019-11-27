namespace DemoValidation.Result
{
    public class ValidationResult
    {
        private bool isValid;
        private string errorMessage;

        public ValidationResult()
        {
            ErrorMessage = "";
        }

        public ValidationResult(bool isValid, string errorMessage)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }

        public bool IsValid { get => isValid; set => isValid = value; }
        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }
    }
}