import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Author } from '../models/author.model';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {
  url = 'http://localhost:7219/api/authors';
  constructor(private http:HttpClient) { }

  findAll() {
    return this.http.get<Author[]>(this.url);
  }

  findById(id: number){
    return this.http.get<Author>(`${this.url}/${id}`);
  }

  findByIdWithInclude(id: number){
    return this.http.get<Author>(`${this.url}/include/${id}`)
  }


  create(Author: Author){
    return this.http.post<Author>(this.url, Author);
  }
  //Borrar por id
  deleteById(id: number) {
    return this.http.delete(`${this.url}/${id}`);
  }

  update(Author: Author){
    return this.http.put<Author>(this.url, Author);
  }
}
