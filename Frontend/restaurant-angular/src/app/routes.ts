import { Routes } from '@angular/router';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { HomeComponent } from 'src/app/components/home/home.component';
import { MenuComponent } from './components/menu/menu.component';
import { BillComponent } from './components/bill/bill.component';

export const appRoutes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'menu/:tableId/:mealId', component: MenuComponent },
  { path: 'bill/:tableId', component: BillComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent}
];