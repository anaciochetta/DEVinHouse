import { Component, OnInit } from '@angular/core';
import { ICardapio } from 'src/app/models/lista.model';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'ngf-comidas',
  templateUrl: './comidas.component.html',
  styleUrls: ['./comidas.component.scss'],
})
export class ComidasComponent implements OnInit {
  listaComidas: ICardapio[] = [];
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.buscarComidas();
  }

  buscarComidas() {
    this.http
      .get<ICardapio[]>('http://localhost:3000/comidas')
      .subscribe((resultado) => {
        this.listaComidas = resultado;
      });
  }
}
