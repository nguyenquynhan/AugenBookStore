import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { environment } from '../../environments/environment';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { Observable } from 'rxjs';

@Injectable()
export class BookService {

    constructor(private _http: Http) {
    }

    getBooks(textSearch = '') {
        return this._http.get(environment.apiHost + `/api/books?textSearch=${textSearch}`).map(this.extractData);
    }

    getBookById(bookId) {
        return this._http.get(environment.apiHost + `/api/books/${bookId}`).map(this.extractData);
    }

    buyBook(buyBook) {
        return this._http.post(environment.apiHost + `/api/books/buybook`, buyBook).map((res: Response) => { return res.text() });
    }

    private extractData(res: Response) {
        let body = res.json();
        return body;
    }
}