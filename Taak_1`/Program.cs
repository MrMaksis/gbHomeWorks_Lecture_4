// Task 1 - в этом задании я намерено сделал все так сложно (мог просто, но не захотел)

int NaturalDegree(int A, int B)
{
    int _add = A; 

    for(int i = 0; i < B; i++)
        _add = _add * A;
        return _add;
}

int[] InputNums()
{
    int[] inpStr = new int[2];
    Console.Write("Введите первое число: ");
    inpStr[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    inpStr[1] = Convert.ToInt32(Console.ReadLine());

    return inpStr;
}

int[] _temp = InputNums();
Console.WriteLine(NaturalDegree(_temp[0],_temp[1]));
