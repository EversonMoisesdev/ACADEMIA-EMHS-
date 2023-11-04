import { AlunosService } from './../../../services/alunos.service';
import { Component, OnInit } from '@angular/core';
import { Aluno } from 'src/app/shared/model/aluno-model';

@Component({
  selector: 'app-consulta-alunos',
  templateUrl: './consulta-alunos.component.html',
  styleUrls: ['./consulta-alunos.component.css']
})
export class ConsultaAlunosComponent implements OnInit {
  /*
Atributos
*/
  alunos: Aluno[] = [];
  quantidadeDeAlunos: number = 0;

  constructor(private alunosService: AlunosService) {}

  ngOnInit(): void {
    this.alunosService.getAllAlunos().subscribe(data =>{
      this.alunos = data
      this.quantidadeDeAlunos = this.alunos.length;
    })

  }
}

