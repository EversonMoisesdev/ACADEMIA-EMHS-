using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service

{
    public class AlunoService : IAlunoService

    {
        public string CreateAluno(Aluno alunoObject)
        {
        return "Aluno criado com sucesso";
        }

        public List<Aluno> GetAllAluno()
        {

            var listaAlunos = new List<Aluno>();


            var objetoAlluno1 = new Aluno();
            objetoAlluno1.matricula = 1234;
            objetoAlluno1.nome = "Theo";

            var objetoAlluno2 = new Aluno();
            objetoAlluno2.matricula = 1234;
            objetoAlluno2.nome = "Theo";

            var objetoAlluno3 = new Aluno();
            objetoAlluno3.matricula = 1234;
            objetoAlluno3.nome = "Theo";

            listaAlunos.Add(objetoAlluno1);
            listaAlunos.Add(objetoAlluno2);
            listaAlunos.Add(objetoAlluno3);

            return listaAlunos;
        }
    }
}
