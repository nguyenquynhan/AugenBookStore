import {Routes, RouterModule} from '@angular/router';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
    {
        path: '',
        component: HomeComponent
    },
    {
        path: 'books',
        component: HomeComponent
    }
];

export const routeModule = RouterModule.forRoot(routes);