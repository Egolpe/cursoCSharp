import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../models/book.model';

@Injectable({
  providedIn: 'root'
})
export class BookService {
  url = 'http://localhost:7219/api/books';
  constructor(private http:HttpClient) { }

  findAll() {
    return this.http.get<Book[]>(this.url);
  }

  findById(id: number){
    return this.http.get<Book>(`${this.url}/${id}`);
  }

  findByIdWithInclude(id: number){
    return this.http.get<Book>(`${this.url}/include/${id}`)
  }
  //Borrar por id
  deleteById(id: number) {
    return this.http.delete(`${this.url}/${id}`);
  }
}
