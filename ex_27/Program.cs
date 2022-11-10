// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, write number");
string number = Console.ReadLine();

sumNumber(number);

void sumNumber(string a){
int sum = 0;
    if (a != "")
    { 
        for (int i = 0; i <= a.Length-1; i++)
        {
            int b = Convert.ToInt32(new string(a[i], 1));
            sum = sum + b;
        }   
    }
    Console.WriteLine(sum);
}