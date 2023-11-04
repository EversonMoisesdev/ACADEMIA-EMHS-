import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CadastroAlunosComponent } from './cadastro-alunos/cadastro-alunos.component';
import { ConsultaAlunosComponent } from './consulta-alunos/consulta-alunos.component';
import { EdicaoAlunosComponent } from './edicao-alunos/edicao-alunos.component';
import { CadastroFuncionariosComponent } from './cadastro-funcionarios/cadastro-funcionarios.component';
import { ConsultaFuncionariosComponent } from './consulta-funcionarios/consulta-funcionarios.component';
import { CadastroFornecedoresComponent } from './cadastro-fornecedores/cadastro-fornecedores.component';
import { ConsultaFornecedoresComponent } from './consulta-fornecedores/consulta-fornecedores.component';



//mapeamento das rotas do projeto
const routes: Routes = [
  { path: 'pages/cadastro-alunos', component: CadastroAlunosComponent },
  { path: 'pages/consulta-alunos', component: ConsultaAlunosComponent },
  { path: 'pages/edicao-alunos/:id', component: EdicaoAlunosComponent },
  { path: 'pages/cadastro-funcionarios', component: CadastroFuncionariosComponent },
  { path: 'pages/consulta-funcionarios', component: ConsultaFuncionariosComponent },
  { path: 'pages/cadastro-fornecedores', component: CadastroFornecedoresComponent },
  { path: 'pages/consulta-fornecedores', component: ConsultaFornecedoresComponent },
  { path: '', pathMatch: 'full', redirectTo: '/pages/consulta-alunos' },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}



