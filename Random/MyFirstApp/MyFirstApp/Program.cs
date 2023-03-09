int x = 5;

for (int i = 0; i < 10; i++)
{
    x += 1;
    Console.WriteLine(x);
}

string firstName = "John";
string lastName = "Doe";

string fullName = $"My full name is: {firstName} {lastName}";
Console.WriteLine(fullName);

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (var number in numbers)
{
    Console.Write(number + " ");
}

int[,] nums = new int[3, 2] { { 9, 99 }, { 3, 33 }, {
5, 55 } };

Console.WriteLine();

foreach (var number in nums)
{
    Console.Write("{0} ", number);
}

Console.WriteLine();

string[] input = Console.ReadLine().Split(" ");
foreach (string word in input)
{
    Console.Write($"{word}, ");
}