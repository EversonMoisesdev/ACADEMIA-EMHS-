using Domain.Entities;
using Domain.Interface;

namespace Infra
{
    public class AlunoRepository : IAlunoRepository

    {
        public string CreatAluno(Aluno aluno)
        {
            return "Aluno cadastrado com sucesso";
           
        }

        public List<Aluno> GetAll()
        {
            var listaAlunos = new List<Aluno>();


            var objetoAlluno1 = new Aluno();
            objetoAlluno1.matricula = 1231;
            objetoAlluno1.nome = "Daniel";

            var objetoAlluno2 = new Aluno();
            objetoAlluno2.matricula = 1232;
            objetoAlluno2.nome = "Everson";

            var objetoAlluno3 = new Aluno();
            objetoAlluno3.matricula = 1233;
            objetoAlluno3.nome = "Henrique";

            listaAlunos.Add(objetoAlluno1);
            listaAlunos.Add(objetoAlluno2);
            listaAlunos.Add(objetoAlluno3);

            return listaAlunos;
            
        }
    }
}