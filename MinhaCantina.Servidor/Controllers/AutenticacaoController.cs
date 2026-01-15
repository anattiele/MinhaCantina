using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MinhaCantina.Servidor.Controllers;

[Route("[controller]")]
[ApiController]
public class AutenticacaoController : ControllerBase
{
	// modificadorAcesso tipoCampo NomeCampo = Valor;
	private string Usuario = "Funcionario";
	private string Senha = "123";

	// GET, POST, PATCH/PUT, DELETE
	// Pegar, Criar, Alterar, Excluir
	// Sintaxe do Método
	// modificadorAcesso tipoRetorno NomeMetodo(tipoParametro nomeParametro)
	[HttpGet("/login")]
	public IActionResult Login(string nomeUsuario, string senhaUsuario)
	{
		if (Usuario != nomeUsuario)
		{
			return StatusCode(400, "Usuario e/ou senha estão incorretos");
		}

		if (Senha != senhaUsuario)
		{
			return StatusCode(400, "Usuario e/ou senha estão incorretos");
		}

		return StatusCode(200);
	}
}
