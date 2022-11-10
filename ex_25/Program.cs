// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, write number for A!");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hello, write number for B!");
int number_b = Convert.ToInt32(Console.ReadLine());

Exponentiate(number_a, number_b);

void Exponentiate(int x, int stepen){
    Console.WriteLine("a^b = " + Math.Pow(x, stepen));
}
