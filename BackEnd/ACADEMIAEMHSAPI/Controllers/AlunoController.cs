
using Domain.Entities;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ACADEMIAEMHSAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        //Para fazer injeção de dependencia - Selecionar a linha do private readonly IAlunoService _alunoService; e clicar na lampada"ações rapidas e faturações, e Gerar construtor.


        private readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;

        }
        [HttpPost("CreateAluno")]

        public ActionResult CreatAluno(Aluno alunoObject)
        {
            _alunoService.CreateAluno(alunoObject);

            

            return Ok(alunoObject);


        }

        [HttpGet("GetAllAlunos")]

        public ActionResult GetAllAlunos()
        {          

            var resultado = _alunoService.GetAllAluno();        

            return Ok(resultado);
        }


    }
}
