namespace MinhaCantina.Biblioteca.DTOs;

public class ProdutoRegistroDto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string? Descricao { get; set; }
    public int CategoriaId { get; set; }
}
