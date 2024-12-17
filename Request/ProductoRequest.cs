namespace Examen05.Request
{
    public class ProductoRequest
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        //definiendo llaves foraneas
        public int CategoriaId { get; set; }
    }
}
