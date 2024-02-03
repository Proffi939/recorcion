// lesson 7 recursion
void GetNaturalNumbersBetween(int n, int m)
{
    if (n < m + 1)
    {
        Console.Write($"{n}, ");
        GetNaturalNumbersBetween(n + 1, m);
    }
    return;
}
int [] MakeRndIntArr(int size)
{
    Random rnd = new Random();
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr [i] = rnd.Next(1, 10);
    }  
    return arr;
}
void ArrPrint(int [] array)
{
    foreach(int i in array)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}
void PrintRewerseArray(int [] arr, int i)
{
    if (i < arr.Length)
    {        
        PrintRewerseArray(arr, i+1);
        Console.Write($"{arr[i]}, ");
        return;
    }
    return;
}
int AkkermanResult(int m, int n)
        {
        if (m == 0) return n + 1;
        else if (n == 0) return AkkermanResult(m - 1, 1);
        else return AkkermanResult(m - 1, AkkermanResult(m, n - 1));
        }

int task = 0;
while(task != 4)
{
    Console.WriteLine("Выберите номер задания или 4 для выхода");
    task = Convert.ToInt32(Console.ReadLine());
    //task 1
    if (task == 1)
    {
        Console.WriteLine("Введите начало интервала");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите окончание интервала");
        int m = Convert.ToInt32(Console.ReadLine());
        GetNaturalNumbersBetween(n, m);
        Console.WriteLine();
    }
    //task 3
    if (task == 3)
    {
        Console.WriteLine("Введите размер массива ");
        int arrsize = Convert.ToInt32(Console.ReadLine());
        int [] arr = MakeRndIntArr(arrsize);
        Console.WriteLine("сгенерированный массив ");
        ArrPrint(arr);
        Console.WriteLine("реверс массива");
        int i = 0;
        PrintRewerseArray(arr, i);
        Console.WriteLine();
    } 
    //task 2
    if (task == 2)//не понятно как, но главное задача решена
    {
        Console.WriteLine("Введите значение m");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение n");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат = {AkkermanResult(m, n)} ");
        Console.WriteLine();
        
    } 
}
Console.WriteLine("end");





