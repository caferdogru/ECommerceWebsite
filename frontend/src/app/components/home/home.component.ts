import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from 'src/app/models/product.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {


  products: Product[];

  constructor(
    public productService: ProductService,
    public productCategoryService: ProductCategoryService,
    public router: Router
  ) {

   }


  getAllProducts() {
    this.productService.getAll().subscribe(result => {
      this.products = result;
    })
  }

  deleteProduct(product:Product) {
    this.productService.delete(product.id).subscribe(res => {
      this.getAllProducts();
    })
  }


  showProductDetail(product:Product) {
    this.router.navigate(['/Product', {id: product.id}]);
  }

  ngOnInit(): void {
    this.getAllProducts();
    this.productCategoryService.getAll().subscribe(res => {
      this.productCategoryService.productCategories = res;
    });
  }


}
