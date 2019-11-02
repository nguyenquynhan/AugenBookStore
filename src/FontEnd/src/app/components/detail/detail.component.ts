import {Router, ActivatedRoute, Params} from '@angular/router';
import {OnInit, OnDestroy, Component, Pipe} from '@angular/core';
import { DeliveryService } from '../../services/delivery.service';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import * as CryptoJS from 'crypto-js';
import { environment } from '../../../environments/environment';

@Component({
    selector: 'detail',
    templateUrl: './detail.component.html',
    styleUrls: ['./detail.component.scss']
})
export class DetailComponent implements OnInit {
    @BlockUI() blockUI: NgBlockUI;
    

    constructor(private _activatedRoute: ActivatedRoute,
        private _deliveryService: DeliveryService)
    { }

    ngOnInit() {
        
    }
}
