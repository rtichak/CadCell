import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  public eventos: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void{

    this.getEventos();

  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/Evento').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }
}
