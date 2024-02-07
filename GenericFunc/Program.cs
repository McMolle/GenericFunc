using GenericFunc;


//Opgave 1
List<int> intList = new List<int>() { 5, 10, 3, 8, 15 };
Console.WriteLine("Largest element in intList: " + Functions.FindLargest(intList)); // Output: 15

//Opgave 2
List<double> doubleList = new List<double>() { 3.14, 2.718, 1.618, 2.0 };
Console.WriteLine("Largest element in doubleList: " + Functions.FindLargest(doubleList)); // Output: 3.14

List<string> stringList = new List<string>() { "apple", "banana", "orange", "kiwi" };
Console.WriteLine("Largest element in stringList: " + Functions.FindLargest(stringList)); // Output: orange

