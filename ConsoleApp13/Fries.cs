namespace ConsoleApp13;

public class Fries : Food
{
    public double Weight;
    public bool IsSalty;

    public Fries(int id, string name, DateTime releaseDate, TimeSpan preparationTime, double calories, double weight,
        bool isSalty) : base(id, name, releaseDate, preparationTime, calories)
    {
        Weight = weight;
        IsSalty = isSalty;
    }

    public override void CalcPrice()
    {
        Price = Weight * 1;
        if (IsSalty)
        {
            Price += 0.8;
        }

        Console.WriteLine("the price of the fries is " + Price.ToString("F2") + " AZN");
    }

    public override string ToString()
    {
        return base.ToString() + $" Price {Price.ToString("F2")} Weight: {Weight} Is Salty: {IsSalty} ";
    }
}