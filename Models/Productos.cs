namespace Examen05.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }   
        public decimal Precio { get; set; }

        //definiendo llaves foraneas

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
