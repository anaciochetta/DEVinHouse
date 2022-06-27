import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IOpcao } from 'src/app/models/opcao.model';

@Component({
  selector: 'ngf-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss'],
})
export class ContentComponent implements OnInit {
  listaDeOpcoes: IOpcao[] = [];

  constructor(private route: Router, private http: HttpClient) {}

  ngOnInit(): void {
    this.gerarPagina();
  }

  gerarPagina() {
    this.http
      .get<IOpcao[]>('http://localhost:3000/opcoes')
      .subscribe((resultado) => {
        this.listaDeOpcoes = resultado;
      });
  }
  redirecionar(path: string) {
    this.route.navigateByUrl(path);
  }
}
