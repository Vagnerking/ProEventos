import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

public eventos: any = [];
public eventosFiltrados: any = [];
widthImg: number = 50;
marginImg: number = 2;
showImg: boolean = true;
private _filtroLista: string = '';

public get filtroLista() {
return this._filtroLista;
}

public set filtroLista(value: string) {
  this._filtroLista = value;
  this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
}

filtrarEventos(filtro: string) : any
{
  filtro = filtro.toLocaleLowerCase();
  return this.eventos.filter(
    (evento : any) => evento.tema.toLocaleLowerCase().indexOf(filtro) !== -1 ||
    evento.local.toLocaleLowerCase().indexOf(filtro) !== -1
  );
}

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }

public btnShowFunc(): void
{
  this.showImg = !this.showImg;
}


public getEventos(): void
{

  this.http.get('https://localhost:5001/api/v1/eventos').subscribe(
    response => {
      this.eventos = response
      this.eventosFiltrados = this.eventos;
    },
    error => console.log(error)
  );

}


}
