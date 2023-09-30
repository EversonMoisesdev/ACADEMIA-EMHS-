import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdicaoAlunosComponent } from './edicao-alunos.component';

describe('EdicaoAlunosComponent', () => {
  let component: EdicaoAlunosComponent;
  let fixture: ComponentFixture<EdicaoAlunosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EdicaoAlunosComponent]
    });
    fixture = TestBed.createComponent(EdicaoAlunosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
