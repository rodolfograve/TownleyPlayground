using ConsoleUI;

MyClass obj1 = new MyClass("Object 1");
MyClass obj2 = obj1;

obj2.Name = "Testing this";

Console.WriteLine(obj1.Name);
Console.WriteLine(obj2.Name);

List<int> v = [20, 10, 50, 40, 30];

IEnumerable<int> v2 = v.Order();

Console.WriteLine($"Output #1.1: {string.Join(", ", v)}");
Console.WriteLine($"Output #1.2: {string.Join(", ", v2)}");

v.Sort();
v2 = v;

Console.WriteLine($"Output #2.1: {string.Join(", ", v)}");
Console.WriteLine($"Output #2.2: {string.Join(", ", v2)}");

v[0] = 100;

Console.WriteLine($"Output #3.1: {string.Join(", ", v)}");
Console.WriteLine($"Output #3.2: {string.Join(", ", v2)}");

