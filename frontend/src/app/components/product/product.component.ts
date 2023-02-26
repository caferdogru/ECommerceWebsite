import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Product } from 'src/app/models/product.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  product: Product;


  constructor(
    public productService: ProductService,
    public productCategoryService: ProductCategoryService,
    private route: ActivatedRoute,
  ) {
    

  }


  ngOnInit(): void {
    const productId = Number(this.route.snapshot.paramMap.get('id'));
    this.productService.get(productId).subscribe(res => {
      this.product = res;
    })
  }


    
}
