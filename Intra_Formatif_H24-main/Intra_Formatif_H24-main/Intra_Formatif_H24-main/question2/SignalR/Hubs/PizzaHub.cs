using Microsoft.AspNetCore.SignalR;
using SignalR.Services;

namespace SignalR.Hubs
{
    
    public class PizzaHub : Hub
    {
        private readonly PizzaManager _pizzaManager;
        

        public PizzaHub(PizzaManager pizzaManager) {
            _pizzaManager = pizzaManager;
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            _pizzaManager.AddUser();
            await Clients.All.SendAsync("UpdateNbUsers", _pizzaManager.NbConnectedUsers);
            
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            
            await base.OnDisconnectedAsync(exception);
            _pizzaManager.RemoveUser();
            await Clients.All.SendAsync("UpdateNbUsers", _pizzaManager.NbConnectedUsers);

        }

        public async Task SelectChoice(PizzaChoice choice)   
            
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, _pizzaManager.GetGroupName(choice));
            await Clients.Group(_pizzaManager.GetGroupName(choice)).SendAsync("UpdatePizzaPrice", _pizzaManager.PIZZA_PRICES[(int)choice], _pizzaManager.Money[(int)choice], _pizzaManager.NbPizzas[(int)choice]);
            //ait Clients.Caller.SendAsync("UpdatePizzaPrice", _pizzaManager.PIZZA_PRICES[(int)choice]);
        }

        public async Task UnselectChoice(PizzaChoice choice)
        {

            await Groups.RemoveFromGroupAsync(Context.ConnectionId, _pizzaManager.GetGroupName(choice));
            //await Clients.Group(_pizzaManager.GetGroupName(choice)).SendAsync("UpdatePizzaPrice", 0);
            //await Clients.Caller.SendAsync("UpdatePizzaPrice", 0);
        }

        public async Task AddMoney(PizzaChoice choice)
        {
            _pizzaManager.IncreaseMoney(choice);
            await Clients.Group(_pizzaManager.GetGroupName(choice)).SendAsync("UpdateMoney", _pizzaManager.Money[(int)choice]);
        }

        public async Task BuyPizza(PizzaChoice choice)
        {
            _pizzaManager.BuyPizza(choice);
            await Clients.Group(_pizzaManager.GetGroupName(choice)).SendAsync("UpdateNbPizzasAndMoney", new { Money = _pizzaManager.Money[(int)choice], NbPizza = _pizzaManager.NbPizzas[(int)choice] });
            //await Clients.Caller.SendAsync("UpdateNbPizzasAndMoney", new {Money = _pizzaManager.Money[(int)choice], NbPizza = _pizzaManager.NbPizzas[(int)choice]});
        }
    }
}
