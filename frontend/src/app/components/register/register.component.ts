import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from 'src/app/models/user.model';
import { UserService } from 'src/app/services/user.service';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {


  userForm: FormGroup;
  constructor(
      public userService: UserService,
      public router: Router,
    ) {

  }

  createForm() {
    this.userForm = new FormGroup({
      userId: new FormControl(0),
      firstName: new FormControl(),
      lastName: new FormControl(),
      email: new FormControl(),
      birthday: new FormControl(),
      password: new FormControl(),
    })
  }


  createUser() {
    console.log(this.userForm.value);
    this.userService.create(this.userForm.value).subscribe(res => {
      this.router.navigateByUrl("/Login");
    });
  }


  ngOnInit(): void {
    this.createForm();
  }

}
