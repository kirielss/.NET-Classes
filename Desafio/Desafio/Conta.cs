using System;
using System.Globalization;

namespace Desafio
{
    internal class Conta
    {
        private int TAXA = 5;

        private string _nome;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int numero, double saldo)
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
                if (value != null && value.Split(' ').Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Deposito(double entrada)
        {
            return Saldo += entrada;
        }

        public double Saque(double saida)
        {
            return Saldo -= saida - TAXA;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
