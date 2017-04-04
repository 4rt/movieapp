import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/throw';

import { Movie } from './movie';
import { Category } from './category';

@Injectable()
export class DataService {
    private _baseUrl = 'http://localhost:3552'
    private _apiUrl = this._baseUrl + '/api/movies/';

    constructor(private _http: Http) { }

    getMovies(): Observable<Movie[]> {
        return this._http.get(this._apiUrl)
            .map((response: Response) => <Movie[]>response.json())
            .catch(this.handleError);
    }

    getCategories(): Observable<Category[]> {
        return this._http.get(this._apiUrl + 'categories')
            .map((response: Response) => <Category[]>response.json())
            .catch(this.handleError);
    }

    getMovieById(id: number): Observable<Movie> {
        return this._http.get(this._apiUrl + id)
            .map(this.extractData)
            .catch(this.handleError);
    }

    private extractData(res: Response) {
        let body = res.json();
        return body;
    }

    private handleError(error: Response) {
        // in a real world app, we may send the server to some remote logging infrastructure
        // instead of just logging it to the console
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}