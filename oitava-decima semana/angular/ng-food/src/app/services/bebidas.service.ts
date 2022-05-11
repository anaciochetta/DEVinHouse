import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICardapio } from '../models/lista.model';

@Injectable({
  providedIn: 'root',
})
export class BebidasService {
  constructor(private http: HttpClient) {}

  devolverBebidas(): Observable<ICardapio[]> {
    return this.http.get<ICardapio[]>('http://localhost:3000/bebidas');
  }
}
