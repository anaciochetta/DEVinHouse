import { Component, OnInit } from '@angular/core';
import { Aluno, Nota } from 'src/assets/exercicio10';

@Component({
  selector: 'exemp-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent extends Aluno implements OnInit {
  title = 'exercici10-app';

  media: number;
  passou: boolean;

  constructor() {
    super('', 0, false);
  }

  ngOnInit(): void {
    let aluno1: Aluno = new Aluno('Jonas', 7, false);
    let notas: Nota[] = [
      {
        cadeira: 'Geografia',
        ponto: 4,
        aluno: aluno1,
      },
      {
        cadeira: 'Geografia',
        ponto: 8,
        aluno: aluno1,
      },
      {
        cadeira: 'Geografia',
        ponto: 3,
        aluno: aluno1,
      },
      {
        cadeira: 'Geografia',
        ponto: 10,
        aluno: aluno1,
      },
    ];

    let media: number = 0;
    //looping para somar as notas
    for (let i = 0; i < notas.length; i++) {
      media += notas[i].ponto;
    }

    media = media / notas.length;

    if (aluno1.passou) {
      this.passou = true;
      this.tela = 'Aprovado!!!';
    } else {
      this.passou = false;
      this.tela = 'Reprovado :(';
    }
  }
  //variável para mostrar na tela
  tela: string;
}
