namespace ConsoleAppTest;

public class Salary
{
    
    public int Amount {   get;  set; }
    
    private static Salary? _instance;
    
    
    private Salary()
    {
        
    }

    public static Salary GetInstance()
    {
        if (_instance is null)
        {
            _instance = new Salary();
        }
        
        return _instance;
    }


    public string GetMyNumbers(out string number2)
    {
        number2 = "09112457845";
        
        return "09356667399";
    }
    

    public void DoSomthing2(out int x ) {
        int temp = 5;
        x = temp;
    }
    public int DoSomthing(ref int first)
    {

        first = first + 1;
        

        var a = CalculateA();
        var b = CalculateB();
        var c = CalculateC();
        return a+b/c;
    }



    private int CalculateA()
    {
        return 1;
    }
    
    
    private int CalculateB()
    {
        return 2;
    }
    
    
    private int CalculateC()
    {
        return 3;
    }
}