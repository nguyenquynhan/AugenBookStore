import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { environment } from '../../environments/environment';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { Observable } from 'rxjs';

@Injectable()
export class DeliveryService {

    constructor(private _http: Http) {
        
    }

    getDeliveryTypes() {
        return this._http.get(environment.apiHost + `/api/deliverytypes`).map(this.extractData);
    }

    private extractData(res: Response) {
        let body = res.json();
        return body;
    }
}