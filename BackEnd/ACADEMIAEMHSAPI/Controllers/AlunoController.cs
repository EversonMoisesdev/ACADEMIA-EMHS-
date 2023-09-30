using ACADEMIAEMHSAPI.Entities;
using Microsoft.AspNetCore.Mvc;

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
    //O campo a
    // CreatAluno é o nome de HttpPost
    //[HttpPost(Name = "CreateAluno")]
    //public ActionResult CreatAluno(Aluno alunoObject)
    ////{
    //    string retorno = "Aluno criado com sucesso";

    //    if (alunoObject.peso > 150)

    //    {
    //        string Perigo = " perigo de obesidade ";
    //        return Ok(Perigo);
    //    }

    //    else if (alunoObject.peso > 120)

    //    {
    //        string Cuidado = " Cuidado quase acima do peso ";
    //        return Ok(Cuidado);
    //    }

    //   else

    //    {
    //        string Certo = " Ok ";
    //        return Ok(Certo);
    //    }

    //    }
    //}

    [HttpPost(Name = "MeuPlano")]
    public ActionResult MeuPlano(Aluno PlanoAluno)
    {
        //string P = "voce e um aluno que me tras alegria";
        //string PP = "voce e um aluno que me tras muita alegria";
        //string PPP = "voce e a alegria em pessoa";
        string Pagamento1 = "voce e a alegria em pessoa, mas pagar que e bom, nada ne!";
        string Pagamento2 = "Voce esta de parabens";

        //if (PlanoAluno.Plano == "P")
        //{
        //    return Ok(P);
        //}

        //else if (PlanoAluno.Plano == "PP")
        //{

        //    return Ok(PP);
        //}

        //else if (PlanoAluno.Plano == "PPP")
        //{

        //    return Ok(PPP);

        //}

        if (PlanoAluno.Pagamento == "Pago")
        {

            return Ok(Pagamento2);
        }
        else if (PlanoAluno.Pagamento == "Nao pago")
        {

            return Ok(Pagamento2);
        }

        else
        {
            return BadRequest();
        }

    }
}
