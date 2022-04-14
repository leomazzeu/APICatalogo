namespace APICatalogo.Model
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }

        public ICollection<Produto>Produtos { get; set; }
    }
}
