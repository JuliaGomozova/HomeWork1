int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

Console.WriteLine("введите первое число:");
string numStr1 = Console.ReadLine() ??"";

Console.WriteLine("введите второе число:");
string numStr2 = Console.ReadLine() ??""; 

Console.WriteLine("введите третье число:");
string numStr3 = Console.ReadLine() ??""; 

int num1 = Convert.ToInt32(numStr1);
int num2 = Convert.ToInt32(numStr2);
int num3 = Convert.ToInt32(numStr3);

int max = Max(num1, num2, num3);
Console.WriteLine($"максимальное число {max}");
