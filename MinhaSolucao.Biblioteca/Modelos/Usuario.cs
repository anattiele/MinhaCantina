namespace MinhaCantina.Biblioteca.Modelos;

public class Usuario
{
	public int Id { get; private set; }
	public string Nome { get; private set; } = string.Empty;
	public string Senha { get; private set; } = string.Empty;
	public string Username { get; private set; } = string.Empty;

	private Usuario() { } // Construtor

	public static Usuario Criar(string nome, string senha, string username)
	{
		if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(username))
		{
			throw new Exception("Nome ou username não pode ser vazio");
		}

		if (string.IsNullOrWhiteSpace(senha) || senha.Length < 8)
		{
			throw new Exception("Senha não pode ser vazio ou menor que 8 caracteres");
		}

		return new Usuario()
		{
			Nome = nome,
			Senha = senha,
			Username = username
		};
	}
}
