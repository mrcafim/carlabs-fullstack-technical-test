import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { MealType } from 'src/app/models/enum.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  mealType: MealType;
  tableId: number; 
  constructor(private router: Router,
              private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  openMenu(mealId: string){
    if(this.tableId != undefined){
      this.router.navigate(['/menu', this.tableId, mealId]);
    }else{
      this.toastr.warning("Please, inform your table number", 'Table Number!');
    }
  }

}
