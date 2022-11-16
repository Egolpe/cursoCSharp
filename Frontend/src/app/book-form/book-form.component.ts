import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Author } from '../models/author.model';
import { Book } from '../models/book.model';
import { Category } from '../models/category.model';
import { AuthorService } from '../services/author.service';
import { BookService } from '../services/book.service';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-book-form',
  templateUrl: './book-form.component.html',
  styleUrls: ['./book-form.component.css']
})
export class BookFormComponent implements OnInit {

  editForm = this.createFormGroup();
  error: boolean = false;
  authors: Author[] = [];
  categories: Category[] = [];
  
  constructor(
    private bookService: BookService,
    private authorService: AuthorService,
    private categoryService: CategoryService, 
    private router: Router, 
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {

    //Extraer id de la url 
    this.activatedRoute.paramMap.subscribe(
      {
        next: pmap => {
          let id = pmap.get("id");
          if(id){
            console.log("Existe el Id, es una actualización" + id);
            //recuperar el libro
            this.bookService.findByIdWithInclude(Number(id)).subscribe({
              next: bookFromBackend => {
                this.editForm.reset({
                  id: { value: bookFromBackend.id, disable: true },
                  title: bookFromBackend.title,
                  price: bookFromBackend.price,
                   isbn: bookFromBackend.isbn,
                   description: bookFromBackend.description,
                   authorId: bookFromBackend.authorId,
                   categories: bookFromBackend.categories,
                })
              },
              error: err => console.log(err)
            });
            
          }else{
            console.log("No existe el IdleDeadline, esto es una creación");
          }

        }
        
      }
    );
      this.authorService.findAll().subscribe({
        next: authors => this.authors = authors,
        error: err => console.log(err)
      });

      this.categoryService.findAll().subscribe({
        next: categories => this.categories = categories,
        error: err => console.log(err),
      })
  }
  
  
  

  createFormGroup(){
    return new FormGroup({
      id: new FormControl(),
      isbn: new FormControl(),
      title: new FormControl(),
      releaseYear: new FormControl(),
      price: new FormControl(),
      description: new FormControl(),
      authorId: new FormControl(),
      categories: new FormControl(),
    })
  }
  save() {

   let book = { 
    
    title: this.editForm.get("title")?.value,
    isbn: this.editForm.get("isbn")?.value,
    releaseYear: this.editForm.get("releaseYear")?.value,
    price: this.editForm.get("price")?.value,
    authorId: this.editForm.get("authorId")?.value,
    categories: this.editForm.get("categories")?.value,
    }as any;


    let id = this.editForm.get("id")?.value;
    if(book.id){
      book.id = id;
    this.bookService.update(book).subscribe({
      next: response => this.navigateToList(),
      error: err => console.log(err)
    });
    }else {
      this.bookService.create(book).subscribe({
        next: response => this.navigateToList(),
        error: err => console.log(err)
      });
    }
  }

  private navigateToList(){
    this.router.navigate(["/books"]);
  }
}
