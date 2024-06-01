namespace Demo11.Models
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroFactura { get; set; }
        public float Total { get; set; }
    }
}
