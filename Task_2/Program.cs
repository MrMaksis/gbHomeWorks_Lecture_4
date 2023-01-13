//Task 2 

int[] Result(int num)
{
    int sum = 0;
    int[] _sum = new int[2];

    for(int i = num, _cur = 0; i > 0; i /= 10, _cur++)
    {
        int _num = i % 10;
        _sum[_cur] = sum + _num;
    }
    return _sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма числа {num} равно {Result(num)[0] + Result(num)[1]}");
















// int revers = 0;

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num;

// while (current != 0)
// {
//     revers = revers * 10;
//     revers = revers + current % 10;
//     current = current / 10;
// }
// if(num == revers) Console.WriteLine("Это палиндром.");
// else Console.WriteLine("Это не палиндром.");