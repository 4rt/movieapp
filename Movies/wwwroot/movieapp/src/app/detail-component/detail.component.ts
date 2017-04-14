import { Component, OnInit, Input, Output, EventEmitter, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { Subscription } from 'rxjs/Subscription';
import { Movie } from '../services/movie'
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-detail-component',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent implements OnInit, OnDestroy {
  @Input() rating: number;
  starWidth: number;
  movie: Movie;
  errorMessage: string;

  private sub: Subscription;

  constructor(private _route: ActivatedRoute,
    private _router: Router,
    private _DataService: DataService) {
  }

  ngOnInit(): void {
    this.sub = this._route.params.subscribe(
      params => {
        let id = +params['id'];
        this.getMovieById(id);
      });
  }

  getMovieById(id: number) {
    this._DataService.getMovieById(id).subscribe(
      (movie: Movie) => { this.movie = movie },
      error => this.errorMessage = <any>error);
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

}
