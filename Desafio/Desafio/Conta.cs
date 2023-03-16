using System;
using System.Globalization;

namespace Desafio
{
    internal class Conta
    {
        private int TAXA = 5;

        private string _nome;
        public string Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, string numero, double saldo)
        {
            _nome = nome;
            Numero = numero;
            Saldo = saldo;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value.Split(' ').Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double entrada)
        {
           Saldo += entrada;
        }

        public void Saque(double saida)
        {
           Saldo -= saida + TAXA;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
