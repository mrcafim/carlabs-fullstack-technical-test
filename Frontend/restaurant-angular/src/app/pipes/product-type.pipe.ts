import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'productType'})
export class ProductTypePipe implements PipeTransform {

    transform(productTypeId) {
        let description = '';
        switch(productTypeId) {
            case 1:
                description = 'Dessert';
                break;
            case 2:
                description = 'Drink';
                break;
            case 3:
                description = 'Hamburguer';
                break;
            case 4:
                description = 'Pizza';
                break;
            case 5:
                description = 'Breakfast';
                break;
            case 6:
                description = 'Salad';
                break;
            case 7:
                description = 'Soup';
                break;
            default:
            break;
        }        
        return description;
    }
}

