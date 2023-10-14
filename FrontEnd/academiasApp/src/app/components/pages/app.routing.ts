import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CadastroAlunosComponent } from './cadastro-alunos/cadastro-alunos.component';
import { ConsultaAlunosComponent } from './consulta-alunos/consulta-alunos.component';
import { EdicaoAlunosComponent } from './edicao-alunos/edicao-alunos.component';



//mapeamento das rotas do projeto
const routes: Routes = [
  { path: 'pages/cadastro-alunos', component: CadastroAlunosComponent },
  { path: 'pages/consulta-alunos', component: ConsultaAlunosComponent },
  { path: 'pages/edicao-alunos/:id', component: EdicaoAlunosComponent },
  { path: '', pathMatch: 'full', redirectTo: '/pages/consulta-alunos' },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}



