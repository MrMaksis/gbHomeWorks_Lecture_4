//Task 3

int[] ResultArray(int count)
{
    int[] num = new int[count];

    for(int i = 0; i < count; i++){
        if(i == 0){
            Console.Write("Введите первое число: ");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        else if (i < count - 1){
            Console.Write("Введите следующие число: ");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        else if (i == count - 1){
            Console.Write("Введите последние число: ");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return num;
}

void ResultFor(int count){

    int[] _temp = ResultArray(count);

    for (int i = 0; i < _temp.Length; i++){
        if(i == 0)
            Console.Write($"[ {_temp[i]}; ");
        else if(i == _temp.Length - 1)
            Console.Write($"{_temp[i]} ]");
        else
            Console.Write($"{_temp[i]}, ");
    }   
}

Console.Write("Введите количество элементов массива: ");
ResultFor(Convert.ToInt32(Console.ReadLine()));