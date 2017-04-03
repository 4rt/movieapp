import { Component, OnInit } from '@angular/core';

import {DataService} from '../services/data.service';
import {Movie} from '../services/movie'

@Component({
  selector: 'app-home-component',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

    movies: Movie[];

    errorMessage: string;

    constructor(private _DataService: DataService) {

    }

  ngOnInit(): void {
      this._DataService.getMovies()
              .subscribe(movies => this.movies = movies,
                          error => this.errorMessage = <any>error);
  }

}
