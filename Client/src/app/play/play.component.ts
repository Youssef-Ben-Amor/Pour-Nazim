import { PlayService } from './../services/play.service';
import { UserService } from './../services/user.service';
import { Component, OnInit } from '@angular/core';
import { Game } from './gameLogic/game';
import { MaterialModule } from '../material.module';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Score } from '../models/score';
import { lastValueFrom } from 'rxjs';
@Component({
  selector: 'app-play',
  standalone: true,
  imports: [MaterialModule, CommonModule],
  templateUrl: './play.component.html',
  styleUrl: './play.component.css'
})
export class PlayComponent implements OnInit {

  game: Game | null = null;
  scoreSent: boolean = false;
  constructor(public playService: PlayService) { }

  ngOnDestroy(): void {
    // Ceci est crotté mais ne le retirez pas sinon le jeu bug.
    location.reload();
  }

  ngOnInit() {
    this.game = new Game();
  }

  replay() {
    if (this.game == null) return;
    this.game.prepareGame();
    this.scoreSent = false;
  }

  async sendScore() {
    if (this.scoreSent) return;

    this.scoreSent = true;

    // ██ Appeler une requête pour envoyer le score du joueur ██
    // Le score est dans sessionStorage.getItem("score")
    // Le temps est dans sessionStorage.getItem("time")
    // La date sera choisie par le serveur
    let username = this.playService.GetUsername();
    let token = this.playService.GetToken();

    let httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + token
      })
    };
    let score = this.playService.GetScore();
    let time = this.playService.GetTime();
    let scoreObj = new Score(0, username, Date.now().toString(), time, score, true);
    let x = await this.playService.SendScore(scoreObj, httpOptions);
    console.log(x);
    this.scoreSent = false;

  }


}
