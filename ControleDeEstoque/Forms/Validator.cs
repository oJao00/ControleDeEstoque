using System.Text.RegularExpressions;

public static class Validator
{
    public static bool IsValidEmail(string email)
    {
        // Expressão regular para validação de e-mail
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    public static bool IsValidPhoneNumber(string phoneNumber)
    {
        // Verifica se o número de telefone contém apenas dígitos e tem 10 ou 11 dígitos
        string numeroLimpo = Regex.Replace(phoneNumber, @"\D", "");
        return numeroLimpo.Length == 10 || numeroLimpo.Length == 11;
    }

    public static bool IsValidCity(string city)
    {
        // Expressão regular para validação de cidade, aceitando letras com acentos
        return Regex.IsMatch(city, @"^[a-zA-ZÀ-ÿ' ]+$");
    }

    public static bool IsValidCEP(string cep)
    {
        // Verifica se o CEP está no formato 00000-000
        return Regex.IsMatch(cep, @"^\d{5}-\d{3}$");
    }

    public static bool IsValidState(string state)
    {
        // Verifica se o estado tem exatamente 2 caracteres
        return state.Length == 2;
    }

    public static bool IsValidNumber(string number)
    {
        // Verifica se o número é um inteiro válido
        return int.TryParse(number, out _);
    }
}
