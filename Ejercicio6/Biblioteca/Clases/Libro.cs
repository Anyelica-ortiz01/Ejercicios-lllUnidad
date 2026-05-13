namespace Biblioteca.Clases
{
    public class Libro
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public int AnioPublicacion { get; set; }

        public bool Disponible { get; set; }
    }
}
