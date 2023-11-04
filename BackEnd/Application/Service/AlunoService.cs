using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service

{
    public class AlunoService : IAlunoService //conceito de Herança

    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public string CreateAluno(Aluno alunoObject)
        {
            if (alunoObject.idade > 22)
            {
                return "O Aluno está ficando velho";
            }


          var resultado = _alunoRepository.CreatAluno(alunoObject);

        return resultado;

        }

        public List<Aluno> GetAllAluno()
        {
           

            var resultado = _alunoRepository.GetAll();

            return resultado;
        }
    }
}
