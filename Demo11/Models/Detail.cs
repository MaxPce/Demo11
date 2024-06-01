namespace Demo11.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public Producto Producto { get; set; }
        public int ProductoID { get; set; }


        public int idFactura { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Subtotal { get; set; }

    }
}
