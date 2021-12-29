using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Model
{
    class Reserva
    {
        public string CPF { get; set; }
        public string Quarto { get; set; }
        public string ValorDiaria { get; set; }
        public string Checkin { get; set; }
        public string Checkout { get; set; }
        public string Diarias { get; set; }
        public string ValorTotal { get; set; }
        public string Entrada { get; set; }
        public string ValorFinal { get; set; }
        public string situacaoCheckin { get; set; }
        public string situacaoCheckout { get; set; }
        public string Codigo { get; set; }
        public string Numero { get; set; }
        public string Diaria { get; set; }
        public string Andar { get; set; }
        public string Predio { get; set; }
        public string Tipo { get; set; }
        public string Situacao { get; set; }
        public string Descricao { get; set; }
        public string Buscar { get; set; }
        public byte[] Img1 { get; set; }
        public string Nome { get; set; }
        public string CPFHospede { get; set; }
        public string Nascimento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
