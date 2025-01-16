
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Envase } from '../Interfaces/Envase';
import { Producto } from '../Interfaces/Producto';
import { Cilindro } from '../Interfaces/Cilindro';
import { CilindroJoin } from '../Interfaces/CilindroJoin';

@Injectable({providedIn: 'root'})
export class CilindroService {
  private url:string = "http://localhost:5046/api/"

  constructor(
    private http: HttpClient
  ) { }

  postCilindro(cilindro:Cilindro):Observable<Cilindro>{
    return this.http.post<Cilindro>(this.url + 'cilindro', cilindro);
  }

  getEnvases():Observable<Envase[]>{
    return this.http.get<Envase[]>(this.url + 'envase');

  }
  getProductos():Observable<Producto[]>{
    return this.http.get<Producto[]>(this.url + 'producto');
  }

  getCilindros():Observable<CilindroJoin[]>{
    return this.http.get<CilindroJoin[]>(this.url + 'cilindro');
  }

  deletCilindro(idcilindro:number):Observable<Boolean>{
    return this.http.delete<Boolean>(this.url + 'cilindro/' + idcilindro);
  }

}
