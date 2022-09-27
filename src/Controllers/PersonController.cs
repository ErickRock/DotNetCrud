using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase{

 [HttpGet]
 public Pessoa Get(){
  Pessoa pessoa = new Pessoa("Erick", 26, "12345678998");
  Contrato novoContrato = new Contrato("abc123", 50.46);
 
  pessoa.contratos.Add(novoContrato);
  
  return pessoa;
 }
}
