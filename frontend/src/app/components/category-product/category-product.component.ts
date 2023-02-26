import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/models/product.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-category-product',
  templateUrl: './category-product.component.html',
  styleUrls: ['./category-product.component.css']
})
export class CategoryProductComponent implements OnInit {

  products: Product[];

  constructor(
    public productService: ProductService,
    public productCategoryService: ProductCategoryService,
    private route: ActivatedRoute,
    public router: Router


  ) { }


  
  getProductByCategory(categoryId: number) {
    console.log(categoryId);
    this.productService.getByCategory(categoryId).subscribe(res => {
      this.products = res;
      console.log(res);
    })
  }
  ngOnInit() {
    const categoryId = Number(this.route.snapshot.paramMap.get('id'));
    this.getProductByCategory(categoryId);
    this.productCategoryService.getAll().subscribe(res => {
      this.productCategoryService.productCategories = res;
    });
  }

}
