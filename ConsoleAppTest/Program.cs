// See https://aka.ms/new-console-template for more information

using ConsoleAppTest;

Console.WriteLine("Hello, World!");


var salary = Salary.GetInstance();
salary.Amount=100;


string myNumber2;
string myNumber1= salary.GetMyNumbers(out myNumber2);




int myX;
salary.DoSomthing2(out myX);



var  a = 100;
salary.DoSomthing(ref a);

var salary2 = Salary.GetInstance();
salary2.Amount = 200;

var salary3 = Salary.GetInstance();


//
// var name = "masoud";
//
// var isNotMasoud = name == "masoud"? false : true;





 SumCalculator<int>.Calculate(10, 20);
SumCalculator<double>.Calculate(10.5,20.4);


var listOfStrings = new List<string>();
listOfStrings.Add("aaaa");
listOfStrings.Add("bbb");
listOfStrings.Add("ccc");

var ob = new object();

var person = new Person()
{
 FirstName = "masoud",
 LastName = "ghasemi"
};


var stringOfPerson = person.ToString();



// var list2 = new List<string>() { "kkk", "ffff" };
// listOfStrings.AddRange(list2);
//
// foreach (var item in list2)
// {
//   listOfStrings.Add(item);
// }


//listOfStrings.Insert(1,"yyy");
//listOfStrings.Reverse();

Console.WriteLine();



//
// var listOfPersons = new List<Person>();
//
// listOfPersons.Add(new Person()
// {
//  FirstName = "ali",
//  LastName = "ghasemi"
// });
//
