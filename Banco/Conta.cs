﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private decimal contadorConta = 0;

        // Definição dos atributos internos da Classe
        private Int32 numero;
        private decimal limiteCredito;
        private decimal saldo;
        private DateTime dataAbertura;
        

        // Criação das propriedades da Classe referentes aos atributos internos

        public Int32 Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }

        // Criação dos métodos da Classe

        public void Sacar(decimal valor)
        {
            contadorConta++;
            if (Saldo + LimiteCredito < valor)
            {
                throw new Exception("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }

        public void Depositar(decimal valor)
        {
            Saldo = Saldo + valor;

        }

        // Método construtor da Classe Conta
    }
}
