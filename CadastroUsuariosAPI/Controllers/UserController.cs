using CadastroUsuariosAPI.Models.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuariosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static List<Usuario> users = new List<Usuario>();

    /// <summary>
    /// Adiciona um usuário ao cadastro
    /// </summary>
    /// <response code="201">Retorna o usuário criado</response>
    [HttpPost("cadastrar/")]
    public IActionResult AdicionarUsuario([FromBody] Usuario user)
    {
        // condição para verificar se o cpf já existe no cadastro
        if (users.Any(usuario => usuario.Cpf == user.Cpf))
            return Conflict("Já existe um usuário cadastrado com esse CPF.");

        users.Add(user);
        return CreatedAtAction(nameof(ListarUsuarioPorCpf), new { cpf = user.Cpf }, user);
    }

    /// <summary>
    /// Retorna uma lista de usuários cadastrados
    /// </summary>
    /// <responde code="200">Retorna a lista de usuários</responde>
    [HttpGet("registros/")]
    public IEnumerable<Usuario> ListarUsuarios([FromQuery] int skip = 0, [FromQuery] int take = 10) => users.Skip(skip).Take(take);

    /// <summary>
    /// Retorna um usuário pelo CPF
    /// </summary>
    /// <response code="200">Retorna o usuário</response>
    [HttpGet("{cpf}")]
    public IActionResult ListarUsuarioPorCpf(string cpf)
    {
        var user = users.FirstOrDefault(usuario => usuario.Cpf == cpf);
        return RetornaStatus(user);
    }

    private IActionResult RetornaStatus(Usuario user) // método para retornar o status code
    {
        if (user == null) return NotFound("Usuário não encontrado.");
        return Ok(user);
    }

    /// <summary>
    /// Atualiza um usuário pelo CPF
    /// </summary>
    /// <response code="204">Atualiza um usuário</response>
    [HttpPut("{cpf}")]
    public IActionResult AtualizarUsuario(string cpf, [FromBody] Usuario user)
    {
        var usuario = users.FirstOrDefault(usuario => usuario.Cpf == cpf);
        if (usuario == null) return NotFound("Usuário não encontrado.");

        usuario.Nome = user.Nome;
        usuario.Email = user.Email;
        usuario.Telefone = user.Telefone;

        return NoContent();
    }

    /// <summary>
    /// Deleta um usuário pelo CPF
    /// </summary>
    /// <response code="204">Deleta um usuário</response>
    [HttpDelete("{cpf}")]
    public IActionResult DeletarUsuario(string cpf)
    {
        var usuario = users.FirstOrDefault(usuario => usuario.Cpf == cpf);
        if (usuario == null) return NotFound("Usuário não encontrado.");

        users.Remove(usuario);
        return NoContent();
    }
}
