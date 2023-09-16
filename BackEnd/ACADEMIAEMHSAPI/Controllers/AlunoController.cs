using ACADEMIAEMHSAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ACADEMIAEMHSAPI.Controllers
{
    public class AlunoController
    {
    }
}
[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    [HttpPost (Name ="CreateAluno")] 
    public Aluno CreatAluno (Aluno alunoObject)
    {
        string retorno = "Aluno criado com sucesso";

        return alunoObject;

      
    }   
}
