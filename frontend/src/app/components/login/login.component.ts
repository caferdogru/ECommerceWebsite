import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { UserService } from 'src/app/services/user.service';
import { ProductComponent } from '../product/product.component';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})


export class LoginComponent implements OnInit {

  
  loginForm: FormGroup;
  isLoggedIn: boolean;

  constructor(
      public userService: UserService,
      public router: Router,
      public dialog: MatDialog,
    ) {

  }


  
  createForm() {
    this.loginForm = new FormGroup({
      email: new FormControl(),
      password: new FormControl(),
    })
  }


  login() {
    this.userService.login(this.loginForm.value.email, this.loginForm.value.password).subscribe(res => {
      if(res) {
        this.isLoggedIn = true;
        setTimeout(() => {
          this.router.navigateByUrl("/Home");
        }, 2000)
        ;
      } else {
        this.isLoggedIn = false;
      }
    })

  }


  ngOnInit() {
    this.createForm();
  }


}
