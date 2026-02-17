namespace ConsoleApp13;

public interface IPizzaService
{
    public Pizza GetBiggestRadiusPizza(Pizza[] pizzas);
    public Pizza CreatePizza(int id, string name, DateTime releaseDate, TimeSpan preparationTime, double calories, double radius, 
        bool isSpicy);
}