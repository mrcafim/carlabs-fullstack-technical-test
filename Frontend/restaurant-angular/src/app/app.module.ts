//Angular Modules
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, PreloadAllModules } from '@angular/router';
import { HttpModule } from '@angular/http';
import { NgxPaginationModule } from 'ngx-pagination';

// Application routes
import { appRoutes } from './routes';

// Components
import { AppComponent } from './components/app/app.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { HomeComponent } from './components/home/home.component';
import { NavigationBarComponent } from './components/app/navigation-bar/navigation-bar.component';
import { MenuComponent } from './components/menu/menu.component';
import { RestaurantClientService } from './services/restaurant-client.service';
import { FormsModule } from '@angular/forms';
import { ProductTypePipe } from './pipes/product-type.pipe';
import { ToastrModule } from 'ngx-toastr';
import { BillComponent } from './components/bill/bill.component';


@NgModule({
  declarations: [
    AppComponent,
    BillComponent,
    HomeComponent,
    MenuComponent,
    NavigationBarComponent,
    NotFoundComponent,
    ProductTypePipe
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    HttpModule,
    NgxPaginationModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot(appRoutes, {preloadingStrategy: PreloadAllModules}),
  ],
  providers: [RestaurantClientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
