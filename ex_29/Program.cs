// See https://aka.ms/new-console-template for more information
Console.WriteLine("write number");
//int number_1 = Convert.ToInt32(Console.ReadLine());
string input = Console.ReadLine();
string[] numbers = input.Split(",");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]); 
}
