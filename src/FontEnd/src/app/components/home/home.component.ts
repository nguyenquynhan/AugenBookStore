import {Router, ActivatedRoute, Params} from '@angular/router';
import {OnInit, OnDestroy, Component, Pipe} from '@angular/core';
import { BookService } from '../../services/book.service';
import { DeliveryService } from '../../services/delivery.service';
import { devModeEqual } from '@angular/core/src/change_detection/change_detection';

@Component({
    selector: 'home',
    styleUrls: ['./home.component.scss'],
    templateUrl: './home.template.html'
})
export class HomeComponent implements OnInit{
    books:any = [];
    deliveryTypes:any = [];
    textSearch = '';
    loading = false;
    timer = 0;
    book = null;
    buy:any = {};
    constructor(private _deliveryService: DeliveryService,
        private _bookService: BookService)
    { }

    ngOnInit() {
        this.getBooks();
        this.getDeliveryTypes();
    }
    
    getBooks(){
        this.loading = true;
        this._bookService.getBooks(this.textSearch)
            .subscribe(response => {
                this.books = response;
                this.loading = false;
            }, error => {
                console.log(error);
                this.loading = false;
            });
    }

    getDeliveryTypes(){
        this._deliveryService.getDeliveryTypes()
            .subscribe(response => {
                this.deliveryTypes = response;
            }, error => {
                console.log(error);
            });
    }

    onChange(){
        this.getBooks();
    }

    onClickDetail(id){
        this.buy = {};
        this.getBookById(id);
    }

    getBookById(id){
        this._bookService.getBookById(id)
            .subscribe(response => {
                this.book = response;
            }, error => {
                console.log(error);
            });
    }

    choseDeliveryType(delivery){
        this.buy.book = this.book;
        this.buy.delivery = delivery;
    }
    
    clickConfirm(){
        const buyBook = {
            DeliveryService: this.buy.delivery.name,
            DeliveryCost: this.buy.delivery.cost
        }
        this._bookService.buyBook(buyBook)
            .subscribe(response => {
                this.buy.delivery.info = response;
            }, error => {
                console.log(error);
            })
    }
}
