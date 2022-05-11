import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICardapio } from '../models/lista.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ComidasService {
  constructor(private http: HttpClient) {}

  devolverComidas(): Observable<ICardapio[]> {
    return this.http.get<ICardapio[]>('http://localhost:3000/comidas');
  } //faz buscar no fakebackend, db.json as informações salvas de comidas
}
