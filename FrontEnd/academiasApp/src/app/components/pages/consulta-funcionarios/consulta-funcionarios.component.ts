import { Component, OnInit } from '@angular/core';
import { Funcionario } from 'src/app/shared/model/funcionario-model';

@Component({
  selector: 'app-consulta-funcionarios',
  templateUrl: './consulta-funcionarios.component.html',
  styleUrls: ['./consulta-funcionarios.component.css'],
})
export class ConsultaFuncionariosComponent implements OnInit {
  /*
Atributos
*/
  funcionarios: Funcionario[] = [];
  quantidadeDeFuncionario: Number = 0;

  constructor() {}

  ngOnInit(): void {
    this.funcionarios = [
      {
        nome: 'Everson',
        idade: 28,
        cargo: 'Gestor',
      },
      {
        nome: 'Moises',
        idade: 28,
        cargo: 'Gerente',
      },
      {
        nome: 'Andriele',
        idade: 28,
        cargo: 'Assistente',
      },
      {
        nome: 'Daniel',
        idade: 20,
        cargo: 'T.I',
      },

    ];

    this.quantidadeDeFuncionario = this.funcionarios.length
  }
}
