import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MaterialModule } from '../material.module';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { lastValueFrom } from 'rxjs';
import { LoginDTO } from '../models/loginDTO';
import { CommonModule } from '@angular/common';
import { UserService } from '../services/user.service';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [MaterialModule, FormsModule, CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  hide = true;

  registerUsername: string = "";
  registerEmail: string = "";
  registerPassword: string = "";
  registerPasswordConfirm: string = "";

  loginUsername: string = "";
  loginPassword: string = ""
  erreur: boolean = false;
  message: string = "";
  erreur2: boolean = false;


  constructor(public route: Router, private Userservice: UserService) { }

  ngOnInit() {
  }

  async login() {
    try {
      let loginDTO = new LoginDTO(this.loginUsername, this.loginPassword);
      let x = await this.Userservice.login(loginDTO);
      console.log(x);
      if (x && x.token) {
        this.Userservice.saveToken(x.token, this.loginUsername)
      }
      // Redirection si la connexion a réussi :
      this.route.navigate(["/play"]);
    }
    catch (error) {
      this.erreur = true
      this.message = "erreur dans le username ou le mot de passe"
    }


  }

  async register() {
    try {
      let registerDTO = {
        username: this.registerUsername,
        email: this.registerEmail,
        password: this.registerPassword,
        passwordConfirm: this.registerPasswordConfirm
      };
      let x = await this.Userservice.register(registerDTO);
      console.log(x);
    }
    catch (error) {
      this.erreur2 = true
      this.message = "erreur dans le username ou le mot de passe"
    }
  }

}
