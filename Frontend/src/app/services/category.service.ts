import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../models/category.model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  url = 'http://localhost:7219/api/categories';
  constructor(private http:HttpClient) { }

  findAll() {
    return this.http.get<Category[]>(this.url);
  }

  findById(id: number){
    return this.http.get<Category>(`${this.url}/${id}`);
  }

  findByIdWithInclude(id: number){
    return this.http.get<Category>(`${this.url}/include/${id}`)
  }


  create(category: Category){
    return this.http.post<Category>(this.url, category);
  }
  //Borrar por id
  deleteById(id: number) {
    return this.http.delete(`${this.url}/${id}`);
  }

  update(category: Category){
    return this.http.put<Category>(this.url, category);
  }
}
