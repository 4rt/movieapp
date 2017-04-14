import { Component, OnInit, AfterViewInit, OnDestroy, ViewChildren, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, FormControlName } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import 'rxjs/add/operator/debounceTime';
import 'rxjs/add/observable/fromEvent';
import 'rxjs/add/observable/merge';
import { Observable } from 'rxjs/Observable';
import { Subscription } from 'rxjs/Subscription';

import { Movie } from '../services/movie';
import { Category } from '../services/category';
import { DataService } from '../services/data.service';

@Component({
    selector: 'app-create-component',
    templateUrl: './create.component.html',
    styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit, OnDestroy {

    errorMessage: string;
    movieForm: FormGroup;
    movie: Movie;
    sub: Subscription;
    categories: Category[];

    constructor(private _fb: FormBuilder,
        private _route: ActivatedRoute,
        private _router: Router,
        private _DataService: DataService) {

    }

    ngOnInit(): void {
        this.sub = this._route.params.subscribe(
            params => {
                this.getCategories();
            });
        this.movieForm = this._fb.group({
            Title: '',
            Plot: '',
            CategoryId: [1],
            Year: '',
            Rating: '',
            Poster: ''
        });
    }

    getCategories() {
        this._DataService.getCategories().subscribe(
            (categories) => { this.categories = categories },
            error => this.errorMessage = <any>error);
    }

    saveMovie(): void {
        if (this.movieForm.dirty && this.movieForm.valid) {
            let m = Object.assign({}, this.movie, this.movieForm.value);
            this._DataService.saveMovie(m)
                .subscribe(
                () => this.onSaveComplete(),
                (error: any) => this.errorMessage = <any>error
                );
        } else if (!this.movieForm.dirty) {
            this.onSaveComplete();
        }
    }

    onSaveComplete(): void {
        // Reset the form to clear the flags
        this.movieForm.reset();
        this._router.navigate(['/home']);
    }

    ngOnDestroy() {
        this.sub.unsubscribe();
    }

}
