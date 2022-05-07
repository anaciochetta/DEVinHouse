import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IOpcao } from 'src/app/models/opcao.model';

@Component({
  selector: 'ngf-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss'],
})
export class ContentComponent implements OnInit {
  listaDeOpcoes: IOpcao[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.buscarNotificacoes();
  }

  buscarNotificacoes() {
    this.http
      .get<IOpcao[]>('http://localhost:3000/opcoes')
      .subscribe((resultado) => {
        this.listaDeOpcoes = resultado;
      });
  }
  chamarClique() {
    alert('item clicado');
  }
}
