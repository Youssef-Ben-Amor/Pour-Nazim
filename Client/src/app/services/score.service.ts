import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Score } from '../models/score';
import { lastValueFrom } from 'rxjs';
const domain = "https://localhost:7251/"
@Injectable({
  providedIn: 'root'
})
export class ScoreService {

  constructor(private http: HttpClient) { }
  async getPublicScores(): Promise<Score[]> {
    return await lastValueFrom(this.http.get<Score[]>(domain + "api/Scores/GetPublicScore"))
  }
  async getMyScore(): Promise<Score[]> {
    return await lastValueFrom(this.http.get<Score[]>(domain + "api/Scores/GetMyScore"))
  }
  async changeScoreVisibility(score: Score): Promise<any> {
    return lastValueFrom(this.http.put<Score>(domain + "api/Scores/ChangeScoreVisibility/" + score.id, score));
  }
}
