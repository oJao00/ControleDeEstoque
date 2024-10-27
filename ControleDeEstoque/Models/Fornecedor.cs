using ControleDeEstoque.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }

        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome do fornecedor não pode ser vazio.");
                _nome = value;
            }
        }

        public string Contato { get; set; }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (!value.Contains("@") || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email inválido.");
                _email = value;
            }
        }

        private string _cep;
        public string CEP
        {
            get => _cep;
            set
            {
                if (!Regex.IsMatch(value, @"^\d{5}-?\d{3}$"))
                    throw new ArgumentException("CEP inválido. Use o formato 00000-000.");
                _cep = value;
            }
        }

        private string _numero;
        public string Numero
        {
            get => _numero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O número do endereço não pode ser vazio.");
                _numero = value;
            }
        }

        private string _estado;
        public string Estado
        {
            get => _estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 2)
                    throw new ArgumentException("Estado inválido. Use a sigla de 2 letras.");
                _estado = value.ToUpper();
            }
        }

        private string _cidade;
        public string Cidade
        {
            get => _cidade;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
                    throw new ArgumentException("Cidade inválida. Use apenas letras.");
                _cidade = value;
            }
        }

        public string Complemento { get; set; }
    }
}
