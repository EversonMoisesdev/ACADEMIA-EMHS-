
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static Domain.Entities.FuncionarioController;

namespace ACADEMIAEMHSAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class FuncionarioController : ControllerBase
    {
        [HttpPost(Name = "CreateFucionario")]
        public ActionResult CreatFuncionario(Funcionario funcionarioObject)
        {

            string variavelRetorno = "Retornado com sucesso";


            if (funcionarioObject.Idade< 18) 
            {
                string fucionarioM = "Funcionario de menor idade";
                return Ok(fucionarioM);
            }
               

            return Ok(variavelRetorno);


        }

        [HttpGet(Name = "GetAllFuncionarios")]

        public ActionResult GetAllFuncionarios()
        {

            var listaFuncionarios = new List<Funcionario>();


            var objetoAllFuncionario1 = new Funcionario();
            objetoAllFuncionario1.Nome = "Theo";
            objetoAllFuncionario1.Idade = 13;
            objetoAllFuncionario1.Genero = "Masc";
            objetoAllFuncionario1.Cpf = 12344;

            var objetoAllFuncionario2 = new Funcionario();
            objetoAllFuncionario2.Nome = "Brian";
            objetoAllFuncionario2.Idade = 27;
            objetoAllFuncionario2.Genero = "Masc";
            objetoAllFuncionario2.Cpf = 123445;

            var objetoAllFuncionario3 = new Funcionario();
            objetoAllFuncionario3.Nome = "Jorge";
            objetoAllFuncionario3.Idade = 13;
            objetoAllFuncionario3.Genero = "Masc";
            objetoAllFuncionario3.Cpf = 12344;

            listaFuncionarios.Add(objetoAllFuncionario1);
            listaFuncionarios.Add(objetoAllFuncionario2);
            listaFuncionarios.Add(objetoAllFuncionario3);

            return Ok(listaFuncionarios);


        }


    }
}

