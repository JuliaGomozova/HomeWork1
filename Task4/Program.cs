Console.WriteLine("Введите число больше нуля:");
string numStr = Console.ReadLine() ??"";

int num = Convert.ToInt32(numStr);
if (num <= 0 )
{
    Console.WriteLine("Число должно быть больше нуля");
}
else
{
    Console.WriteLine($"Четные числа от 1 до {num}:");
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}


