using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Lancamento
    {
        // Definição dos atributos internos da classe

        private DateTime dataHoraLancamento;
        private char tipoLancamento; // 'D' pix débito, 'C' pix crédito
        private double valorLancamento;
        private String mensagem;
        private String pessoa;

        public String TxtExtrato()
        {
            string texto;
            texto = dataHoraLancamento.ToString("dd/MM/yyyy hh:mm:ss") + " - " + mensagem + " - ";

            if (tipoLancamento == 'D')
                texto = texto + " Pix Débito";
            else
                texto = texto + " Pix Crédito";

            texto += "Valor: " + valorLancamento.ToString("C");
            return texto;
        }
        
    }
}
