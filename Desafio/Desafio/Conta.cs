using System;
using System.Globalization;

namespace Desafio
{
    internal class Conta
    {
        private string _nome;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int numero)
        {
            _nome = nome;
            Numero = numero;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Split(' ') == string[] ) 
                _nome = value;
            }
        }
    }
}
