import { ScoreService } from './../services/score.service';
import { Component } from '@angular/core';
import { Score } from '../models/score';
import { MaterialModule } from '../material.module';
import { CommonModule } from '@angular/common';
import { Round00Pipe } from '../pipes/round-00.pipe';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { lastValueFrom } from 'rxjs';
const domain = "https://localhost:7251/"

@Component({
  selector: 'app-score',
  standalone: true,
  imports: [MaterialModule, CommonModule, Round00Pipe],
  templateUrl: './score.component.html',
  styleUrl: './score.component.css'
})
export class ScoreComponent {

  myScores: Score[] = [];
  publicScores: Score[] = [];
  userIsConnected: boolean = false;

  constructor(public scoreService: ScoreService) { }

  async ngOnInit() {

    this.userIsConnected = localStorage.getItem("token") != null;
    this.getPublicScores();
    if (this.userIsConnected) {
      this.getMyScore();
    }
  }

  async getPublicScores() {
    let x = await this.scoreService.getPublicScores();
    console.log(x);
    this.publicScores = x;
  }
  async getMyScore() {
    let x = await this.scoreService.getMyScore();
    console.log(x);
    this.myScores = x;
  }

  async changeScoreVisibility(score: Score) {
    score.isPublic = !score.isPublic;
    try {
      let x = await this.scoreService.changeScoreVisibility(score);
      console.log(x);
      this.getPublicScores();
    }
    catch (error) {
      console.error("Error changing score visibility:", error);
    }
  }
}
