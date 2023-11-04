import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Aluno } from '../shared/model/aluno-model';

@Injectable({
  providedIn: 'root'
})
export class AlunosService {

  constructor(private httpClient: HttpClient) { }

  getAllAlunos(){
    return this.httpClient.get<Aluno[]>('https://localhost:7253/Aluno/GetAllAlunos')
  }

  createAluno(aluno: Aluno){
    return this.httpClient.post<any>('https://localhost:7253/CreateAluno', aluno)
  }
}

