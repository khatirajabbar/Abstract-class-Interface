namespace ConsoleApp13;

class  Program
{
    static void Main(string[] args)
    {
        Pizza pizza = new Pizza(1, "margarita", DateTime.Now, TimeSpan.FromMinutes(10), 200, 5,
            true);
        pizza.CalcPrice();
        Fries fries = new Fries(2, "Fries", DateTime.Now, TimeSpan.FromMinutes(5), 100, 3.5, true );
        fries.CalcPrice();
        Console.WriteLine(pizza);
        Console.WriteLine(fries);
        //IFoodService foodService = new FoodService();
        FoodService foodService = new FoodService();
        Console.WriteLine(foodService.WhenWillBePrapered(pizza.PreparationTime));
        //Console.ReadLine(foodService.MoreThanNCalories(pizza.Calories));
        
    }
}