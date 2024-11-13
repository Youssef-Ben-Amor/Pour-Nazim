import { Injectable } from '@angular/core';
import { Score } from '../models/score';
import { lastValueFrom } from 'rxjs';
import { HttpClient } from '@angular/common/http';
const domain = "https://localhost:7251/"
@Injectable({
  providedIn: 'root'
})
export class PlayService {

  constructor(private http: HttpClient) { }
  GetToken(): string {
    return localStorage.getItem("token") ?? '';
  }

  GetUsername(): string {
    return sessionStorage.getItem("name") ?? '';
  }

  GetScore(): string {
    return sessionStorage.getItem("score") ?? '';
  }

  GetTime(): string {
    return sessionStorage.getItem("time") ?? '';
  }

  async SendScore(scoreObj: Score, options: any): Promise<any> {
    return await lastValueFrom(this.http.post<any>(domain + "api/Scores/PostScore", scoreObj, options));
  }

}
