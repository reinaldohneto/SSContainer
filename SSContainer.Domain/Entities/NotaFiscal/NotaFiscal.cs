using System;

namespace SSContainer.Domain.Entities
{
    public class NotaFiscal : Base
    {
        public NotaFiscal()
        {
        }

        public NotaFiscal(string serieNF, Pedido pedido)
        {
            SerieNF = serieNF;
            Pedido = pedido;

            DataCadastro = DateTime.Now;
            //representação geração assincrona
            DataGeracao = DateTime.Now.AddMinutes(1);
        }
        public int NumeroNF { get; private set; }
        public string SerieNF { get; set; }
        public DateTime DataGeracao { get; private set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; private set; }
    }
}