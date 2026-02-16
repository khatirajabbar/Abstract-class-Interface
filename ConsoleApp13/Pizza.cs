namespace ConsoleApp13;

public class Pizza : Food
{
    public double Radius;
    public bool IsSpicy;
   
    public override void CalcPrice()
    {
        double area = Radius * Radius * Math.PI;
        Price = area * 0.1;
        if (IsSpicy)
            Price += 1.15;
        Console.WriteLine("the price of the pizza is " + Price.ToString("F2") + " AZN");
    }
    
    public Pizza(int id, string name, DateTime releaseDate, TimeSpan preparationTime, double calories, double radius, 
        bool isSpicy) : base(id, name, releaseDate, preparationTime, calories)
    {
       Radius = radius;
       IsSpicy = isSpicy;
    }

    public override string ToString()
    {
        return base.ToString() + $" Price {Price.ToString("F2")} Radius: {Radius} IsSpicy: {IsSpicy} ";
    }
}