import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ProductCategory } from 'src/app/models/product-category.model';
import { ProductCategoryService } from 'src/app/services/product-category.service';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent {

  createProductForm: FormGroup;
  productCategories: ProductCategory[];
  constructor(
    public productService: ProductService,
    public productCategoryService:ProductCategoryService,
    ) {

  }

  createForm() {
    this.createProductForm = new FormGroup({
      id: new FormControl(0),
      name: new FormControl(),
      price: new FormControl(),
      stock: new FormControl(),
      description: new FormControl(),
      imageUrl: new FormControl(),
      category: new FormControl()
    })
  }


  createProduct() {
    this.productService.create(this.createProductForm.value).subscribe(result => {
      
    });
  }

  ngOnInit() {
    this.createForm();
    this.productCategoryService.getAll().subscribe(res => {
      this.productCategories = res;
      console.log(res);
    })
  }
}
