namespace ConsoleAppTest.Animals;

public  class Animal:Object
{
    
    protected int Number { get; set; }
    
    public string Color { get; set; }
    
    public string Weigh { get; set; }
    
    public virtual  void Eat()
    {
        Console.WriteLine("Animal: eating food");
        
    }
}


public class Cat : Animal
{
    
    public int Type { get; set; }


    public int GetNumber()
    {
        var ss = Number;
        return ss;
    }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Cat: eating meal");

    }



    public static Cat operator +(Cat left, Cat righ)
    {
        return new Cat()
        {
            Type = (left.Type * righ.Type)/2,
            Color = left.Color + righ.Color,
            Number = left.Number + righ.Number,
            Weigh = left.Weigh + righ.Weigh
        };
    }
    
    public static Cat operator -(Cat left, Cat righ)
    {

        return null;
    }
    
    public static Cat operator *(Cat left, Cat righ)
    {

        return null;
    }
    
    public static Cat operator /(Cat left, Cat righ)
    {

        return null;
    }
    
}

public class Tiger : Cat
{
    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Tiger: eating meal");

    }
}
