import { Component } from '@angular/core';
import * as signalR from "@microsoft/signalr"
import { MatButtonModule } from '@angular/material/button';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true,
  imports: [NgIf, MatButtonModule]
})
export class AppComponent {
  title = 'Pizza Hub';

  private hubConnection?: signalR.HubConnection;
  isConnected: boolean = false;

  selectedChoice: number = -1;
  nbUsers: number = 0;

  pizzaPrice: number = 0;
  money: number = 0;
  nbPizzas: number = 0;

  constructor() {
    this.connect();
  }

  connect() {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('http://localhost:5282/hubs/pizza')
      .build();

    // TODO: Mettre isConnected à true seulement une fois que la connection au Hub est faite


    this.hubConnection!.on("UpdatePizzaPrice", (price, money, nbPizza) => {
      console.log(price);
      this.money = money;
      this.nbPizzas = nbPizza;
      this.pizzaPrice = price;
    })

    this.hubConnection!.on("UpdateMoney", (money) => {
      console.log(money);
      this.money = money;
    })
    this.hubConnection!.on("UpdateNbUsers", (count: number) => {
      this.nbUsers = count;
      console.log(count);
    });

    this.hubConnection!.on("UpdateNbPizzasAndMoney", (data: { money: number, nbPizza: number }) => {
      this.nbPizzas = data.nbPizza;
      this.money = data.money;

    });
    // TODO On doit ensuite se connecter
    this.hubConnection!.start().then(() => {
      console.log('La connexion au hub a été établie');
      this.isConnected = true;
    })
      .catch(err =>
        console.log("Error while connecting to hub"));


  }

  selectChoice(selectedChoice: number) {
    this.selectedChoice = selectedChoice;
    this.hubConnection!.invoke('SelectChoice', selectedChoice);
  }

  unselectChoice() {
    this.hubConnection!.invoke('UnselectChoice', this.selectedChoice);
    this.selectedChoice = -1;

  }

  addMoney() {
    this.hubConnection!.invoke('AddMoney', this.selectedChoice);
  }

  buyPizza() {
    this.hubConnection!.invoke('BuyPizza', this.selectedChoice);
  }
}
