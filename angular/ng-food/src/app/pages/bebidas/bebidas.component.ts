import { Component, OnInit } from '@angular/core';
import { ICardapio } from 'src/app/models/lista.model';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'ngf-bebidas',
  templateUrl: './bebidas.component.html',
  styleUrls: ['./bebidas.component.scss'],
})
export class BebidasComponent implements OnInit {
  listaBebidas: ICardapio[] = [];
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.buscarBebidas();
  }

  buscarBebidas() {
    this.http
      .get<ICardapio[]>('http://localhost:3000/bebidas')
      .subscribe((resultado) => {
        this.listaBebidas = resultado;
      });
  }
}
