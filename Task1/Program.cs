Console.WriteLine("введите первое число:");
string numStr1 = Console.ReadLine() ??"";

Console.WriteLine("введите второе число:");
string numStr2 = Console.ReadLine() ??""; 

int num1 = Convert.ToInt32(numStr1);
int num2 = Convert.ToInt32(numStr2);

if (num1>num2) 
{
     Console.WriteLine($"число {num1} больше числа {num2}");
}
else if (num2>num1)
{ 
    Console.WriteLine ($"число {num2} больше числа {num1}");
}
else Console.WriteLine($"число {num1} равно числу {num2}");