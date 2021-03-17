import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Menu, Product } from 'src/app/models/menu.model';
import { Message } from 'src/app/models/message.model';
import { CreateOrder } from 'src/app/models/order.model';
import { RestaurantClientService } from 'src/app/services/restaurant-client.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  productsList: Product[] = [];

  tableId: number; 
  search: string = '';
  error: string = '';
  pagination: number = 0;

  constructor(private restaurantApi: RestaurantClientService,
              private router: ActivatedRoute,
              private route: Router,
              private toastr: ToastrService) { }

  ngOnInit() {
    this.router.params.forEach((params: Params) => {
      let menuTypeId = +params['mealId'];
      this.tableId = +params['tableId'];
      this.restaurantApi.getMenuByType(menuTypeId)
        .then((res: any) => {
          this.productsList = res.products;
        });
    })
  }
  getItem(producId: string){
    this.restaurantApi.postOrder(new CreateOrder(this.tableId, producId)).subscribe(() => this.showToast(Message.OrderSuccess));
  }

  showToast(message: string) {
    this.toastr.success(message, 'Order Sent!');
  }

  openBill(){
    this.route.navigate(['/bill', this.tableId]);
  }
}



