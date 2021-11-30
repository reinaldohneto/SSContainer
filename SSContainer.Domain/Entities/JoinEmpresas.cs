namespace SSContainer.Domain.Entities
{
    public class JoinEmpresas : Base
    {
        public Cliente Cliente { get; set; }
        public Empresa EmpresaVendedora { get; set; }
        public Pedido Pedido { get; set; }
    }
}