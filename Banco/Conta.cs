using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        // Definição dos atributos internos da Classe
        private Int32 numero;
        private decimal limiteCredito;
        private decimal saldo;
        private decimal contadorConta = 0;

        // Criação das propriedades da Classe referentes aos atributos internos

        public Int32 Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { LimiteCredito = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        // Criação dos métodos da Classe

        public void Sacar(decimal valor)
        {
            contadorConta++;
            Saldo = Saldo - valor;

        }

        public void Depositar()
        {
            Console.WriteLine("Depósito realizado com sucesso");
        }

        // Método construtor da Classe Conta
    }
}
