import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { Subscription } from 'rxjs/Subscription';

import { DataService } from '../services/data.service';
import { Movie } from '../services/movie'
import { Category } from '../services/category';

@Component({
  selector: 'app-home-component',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  movies: Movie[];
  categories: Category[];
  errorMessage: string;

  private sub: Subscription;

  constructor(
    private _DataService: DataService,
    private _route: ActivatedRoute,
    private _router: Router,) {}

  ngOnInit(): void {
    this.sub = this._route.params.subscribe(
      params => {
        //let id = +params['id'];
        this.getMovies();
        this.getCategories();
      });
  }

  getMovies() {
    this._DataService.getMovies().subscribe(
      (movies) => { this.movies = movies },
      error => this.errorMessage = <any>error);
  }

  getCategories() {
    this._DataService.getCategories().subscribe(
      (categories) => { this.categories = categories },
      error => this.errorMessage = <any>error);
  }
  ngOnDestroy() {
    this.sub.unsubscribe();
  }

}
