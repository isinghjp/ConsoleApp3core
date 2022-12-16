// See https://aka.ms/new-console-template for more information

string[] weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday", "Sunday" };

Range range = ..3;

string[] sublist = weekdays[range];
foreach(string ele in sublist)
{
    Console.WriteLine($"{ele}");
}

//Console.WriteLine($"a={weekdays[range]}");

//Console.WriteLine("Hello, World!");
