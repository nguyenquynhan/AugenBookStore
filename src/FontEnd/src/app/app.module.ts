import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule, JsonpModule } from '@angular/http';
import { routeModule} from './app.routes';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { DetailComponent } from './components/detail/detail.component';
import { BookService } from './services/book.service';
import { DeliveryService } from './services/delivery.service';
import { BlockUIModule } from 'ng-block-ui';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        DetailComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        routeModule,
        JsonpModule,
            BlockUIModule
    ],
    providers: [BookService, DeliveryService],
    bootstrap: [AppComponent]
})
export class AppModule { }
