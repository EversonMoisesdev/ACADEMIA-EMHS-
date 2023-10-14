
using Domain.Entities;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ACADEMIAEMHSAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;

        }
        [HttpPost(Name = "CreateAluno")]
        public ActionResult CreatAluno(Aluno alunoObject)
        {


            string resultado = _alunoService.CreateAluno(alunoObject);

            return Ok(resultado);


        }

        [HttpGet(Name = "GetAllAlunos")]

        public ActionResult GetAllAlunos()
        {


           var resultado =  _alunoService.GetAllAluno();

            return Ok(resultado);
        }


    }
}
