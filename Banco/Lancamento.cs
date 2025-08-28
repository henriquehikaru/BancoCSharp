﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{

    public class Lancamento
    {
        // Definição dos atributos internos da classe
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }
        public string Pagador { get; set; }
        public string Remetente { get; set; }
        public int ContaPagador { get; set; }
        public int ContaRemetente { get; set; }
        public string Mensagem { get; set; }
        public string MetodoPagamento { get; set; }
        public string FormaPagamento { get; set; }

        public Lancamento(string pagador, string remetente, int contaPagador, int contaRemetente, decimal valor, string mensagem, string metodoPagamento, string formaPagamento)
        {
            DataHora = DateTime.Now;
            Pagador = pagador;
            Remetente = remetente;
            ContaPagador = contaPagador;
            ContaRemetente = contaRemetente;
            Valor = valor;
            Mensagem = mensagem;
            MetodoPagamento = metodoPagamento;
            FormaPagamento = formaPagamento;
        }

        public override string ToString()
        {
            string msg = string.IsNullOrWhiteSpace(Mensagem) ? "Sem mensagem" : Mensagem;
            return $"[{DataHora}] {Pagador} (Conta {ContaPagador}) transferiu {Valor:C} para {Remetente} (Conta {ContaRemetente}) via PIX [ {MetodoPagamento} - {FormaPagamento} ].\nMensagem: {Mensagem}";
        }

    }
}
