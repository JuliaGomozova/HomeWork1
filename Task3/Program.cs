Console.WriteLine("Введите число:");
string numStr = Console.ReadLine() ??"";

int num = Convert.ToInt32(numStr);

if (num % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else Console.WriteLine("Число нечетное");