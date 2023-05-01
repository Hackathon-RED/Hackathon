using System.Text.RegularExpressions;

namespace Hackathon.Core.ValueObjects
{
    public class Email
    {
        private readonly string _value;
        private const string EmailPattern = @"^(?=.{1,256})([a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+\.)*[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+@(?:(?!.*[^.]{64,})(?:(?!-)[a-zA-Z0-9-]{1,63}(?<!-)\.)+(?:[a-zA-Z]{2,}|xn--[a-zA-Z0-9]{2,}))$"; // Regex pattern para e-mail

        public Email() { }
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("E-mail não pode ser nulo ou vazio");
            }

            // Verifica se o valor passado é um email válido usando Regex
            if (!Regex.IsMatch(value, EmailPattern))
            {
                throw new ArgumentException("E-mail está com um formato inválido.");
            }

            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public static implicit operator string(Email email)
        {
            return email._value;
        }

        public static explicit operator Email(string value)
        {
            return new Email(value);
        }
    }
}
