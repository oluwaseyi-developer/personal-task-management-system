namespace TaskManagementSystem.Domain.ValueObjects
{
    // Validating Email At The Domain Level
    public class Email
    {
        public string Value { get; private set; }

        private Email() { } // EF Core
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                throw new ArgumentException($"Invalid Email Address");

            Value = value;
        }
    }
}
