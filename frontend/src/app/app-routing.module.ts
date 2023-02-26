import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BasketComponent } from './components/basket/basket.component';
import { CategoryProductComponent } from './components/category-product/category-product.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { AddProductComponent } from './components/product/add-product/add-product.component';
import { ProductComponent } from './components/product/product.component';
import { RegisterComponent } from './components/register/register.component';

const routes: Routes = [
  {
    path:"Home",
    component:HomeComponent
  },
  {
    path:"Product/:id",
    component:ProductComponent
  },
  {
    path:"Category/:id",
    component:CategoryProductComponent
  },
  {
    path:"add-product",
    component: AddProductComponent
  },
  {
    path:"Basket",
    component: BasketComponent
  },
  {
    path:"Register",
    component: RegisterComponent
  },
  {
    path:"Login",
    component: LoginComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
