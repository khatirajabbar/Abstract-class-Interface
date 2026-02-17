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

    public override double CalcPrice()
    {
        double price = (Weight / 1000) * 1; 
        if (IsSalty) price += 0.8;
        return price;
    }
    public override string ToString()
    {
        return base.ToString() + $" Price {Price.ToString("F2")} Weight: {Weight} Is Salty: {IsSalty} ";
    }
}