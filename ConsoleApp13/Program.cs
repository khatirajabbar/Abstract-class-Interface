namespace ConsoleApp13;

class  Program
{
    static void Main(string[] args)
    {
        Pizza[] pizzas = new Pizza[5];
        pizzas[0] = new Pizza(1, "Margherita", DateTime.Now, TimeSpan.FromMinutes(10), 266, 5,
            true);
        pizzas[0].CalcPrice();
        pizzas[1] = new Pizza(1, "Pepperoni", DateTime.Now, TimeSpan.FromMinutes(15), 270, 10,
            true);
        pizzas[2] = new Pizza(1, "New York-style pizza", DateTime.Now, TimeSpan.FromMinutes(280), 200, 8,
            true);
        pizzas[3] = new Pizza(1, "Neapolitan pizza", DateTime.Now, TimeSpan.FromMinutes(300), 200, 13,
            true);
        Fries[] fri = new Fries[4];
        fri[0] = new Fries(1, "Fries", DateTime.Now, TimeSpan.FromMinutes(5), 100, 3.5, true );
        fri[1] = new Fries(2, "Fries1", DateTime.Now, TimeSpan.FromMinutes(10), 150, 3.53, false );
        fri[2] = new Fries(3, "Fries2", DateTime.Now, TimeSpan.FromMinutes(15), 130, 3.54, true );
        fri[3] = new Fries(4, "Fries3", DateTime.Now, TimeSpan.FromMinutes(20), 150, 3.55, true );

        
        
        fri[1].CalcPrice();
        Console.WriteLine(pizzas[0]);
        Console.WriteLine(fri[1]);
        //IFoodService foodService = new FoodService();
        IFoodService foodService = new FoodService();
        Console.WriteLine(foodService.WhenWillPrepared(pizzas[1]));
        //Console.ReadLine(foodService.MoreThanNCalories(pizzas[2].Calories));

        Console.WriteLine(foodService.GetCountByCalories(fri,120));
        
        IPizzaService pizzaService = new PizzaService();
        pizzas[4]=pizzaService.CreatePizza(2, "4cheese", DateTime.Now, TimeSpan.FromMinutes(15), 400, 15,
            false);

        Console.WriteLine(pizzaService.GetBiggestRadiusPizza(pizzas));
        


    }
}