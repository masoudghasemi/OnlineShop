// See https://aka.ms/new-console-template for more information

using ConsoleAppTest;

Console.WriteLine("Hello, World!");

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
