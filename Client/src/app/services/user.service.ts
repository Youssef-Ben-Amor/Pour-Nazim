import { LoginDTO } from './../models/loginDTO';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { lastValueFrom } from 'rxjs';
const domain = "https://localhost:7251/"
@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  async login(LoginDTO: LoginDTO): Promise<any> {
    return await lastValueFrom(this.http.post<any>(domain + "api/Users/Login", LoginDTO));
  }
  async register(RegiterDTO: any): Promise<any> {
    return await lastValueFrom(this.http.post<any>(domain + "api/Users/Register", RegiterDTO))
  }
  saveToken(token: string, username: string): void {
    localStorage.setItem("token", token);
    sessionStorage.setItem("name", username);
  }

}
