import {PipeTransform, Pipe} from '@angular/core'
import {Movie} from '../services/movie';

@Pipe({
    name: 'movieFilter'
})

export class MovieFilterPipe implements PipeTransform {

    transform(value: Movie[], filterBy: string): Movie[]{
        filterBy = filterBy ? filterBy.toLocaleLowerCase() : null;
        return filterBy ? value.filter((movie: Movie) =>
            movie.title.toLocaleLowerCase().indexOf(filterBy) !== -1) : value;
    }
}