/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


int EvenNumCount()
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] Array = new int [n];
    Console.WriteLine("Array");
    for (int i=0; i<Array.Length; i++)
    {
        Array[i] = new Random().Next(100,1000);
        Console.Write (Array[i]+ " ");
    }   
    Console.WriteLine();

    int count = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]%2 == 0) 
        {
            count++;
        }
    }
    Console.WriteLine("count "+ count);
    Console.Write("");
    return count;
}  
try{
EvenNumCount();
}
catch
{
Console.WriteLine("Please use just integers");
}
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int EvenNumCount()
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] Array = new int [n];
    Console.WriteLine("Array");
    for (int i=0; i<Array.Length; i++)
    {
        Array[i] = new Random().Next(1,10);
        Console.Write (Array[i]+ " ");
    }   
    Console.WriteLine();

    int Sum = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (i%2 != 0) 
        {
            Sum += Array[i];
        }
    }
    Console.WriteLine("Sum of element of odd positions "+ Sum);
    Console.Write("");
    return Sum;
}  
try{
EvenNumCount();
}
catch
{
Console.WriteLine("Please use just integers");
}
*/



/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
 элементом массива.
[3 7 22 2 78] -> 76


Первый вариант решения с 0.643657342658424682
double DiffMinMaxRealNum() 
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    double [] Array = new double [n];
    Console.WriteLine("Array:");
    Random rnd = new Random();
    int i = 0;
    for (i=0; i<Array.Length; i++)
    {
        Array[i] = rnd.NextDouble();
        Console.Write (Array[i]+ "  ");
    }   
    Console.WriteLine();

    double Min = 1;
    double Max = 0;
    for (i=0; i<Array.Length; i++)
    {
        if (Array[i] < Min)
        {
           Min = Array[i];   
        } 
        if (Array[i] > Max)
        {
            Max = Array[i];
        }
    }
    double Diff = Max - Min;
    Console.WriteLine("Difference between Min and Max = " + Diff);
    Console.WriteLine();
    return Diff;
}  
try{
    DiffMinMaxRealNum();
}
catch
{
   Console.WriteLine("Please use integer"); 
}

Второй  вариант решения с простыми числами!!!!!!!!!!!!!!!!!!!!!!!!!
double DiffMinMaxReal2Num() 
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    double [] Array = new double [n];
    Console.WriteLine("Array:");

    int i = 0;
    for (i=0; i<Array.Length; i++)
    {
        Array[i] = new Random().Next(1, 10);
        Console.Write (Array[i]+ "  ");
    }   
    Console.WriteLine();

    double Min = 10;
    double Max = 1;
    for (i=0; i<Array.Length; i++)
    {
        if (Array[i] < Min)
        {
           Min = Array[i];   
        } 
        if (Array[i] > Max)
        {
            Max = Array[i];
        }
    }
    double Diff = Max - Min;
    Console.WriteLine("Difference between Min and Max = " + Diff);
    Console.WriteLine();
    return Diff;
}  
try{
    DiffMinMaxReal2Num();
}
catch
{
   Console.WriteLine("Please use integer"); 
}
*/

/*
Задача 19 HARD - необязательная: Напишите программу, которая принимает на вход любое число и проверяет,
 является ли оно палиндромом.

void Palindrom()
{
    Console.WriteLine ("Please input a number:");
    int n = Convert.ToInt32(Console.ReadLine());
    int N = n;

    int count = 1;
    while (n/10 > 0 )
    {
        count++;
        n = n/10;
    }

    int [] Array = new int [count];
    for (int i = 0; i < Array.Length; i++)
    {
        Array [i] = N%10;
        N = N/10;
    }
    Console.WriteLine ();
        
    int TrueKey = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] == Array[count-1])
        {
            count --;
        }   
        else  TrueKey=1;
    }
    if (TrueKey == 1) Console.WriteLine ( "Usual digit");
    else Console.WriteLine ("Palindrom");
}      
try 
{
    Palindrom();
}
catch
{
    Console.WriteLine ( "You should input integers only!");
}
*/

/* Задача 21 HARD - необязательная
Напишите программу, которая принимает на вход целое положительное число N и координаты двух точек
 и находит расстояние между ними в N-мерном пространстве. 
double nDimSpace()
{
    Console.WriteLine("Please input a dimension of space");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] ArrayA = new int [n];
    Console.WriteLine("Please input coordinates of point A in space");
    for (int i=0; i<ArrayA.Length; i++)
    {
        ArrayA[i] = Convert.ToInt32(Console.ReadLine());
    }  
    int [] ArrayB = new int [n];
    Console.WriteLine("Please input coordinates of point B in space");
    for (int i=0; i<ArrayB.Length; i++)
    {
        ArrayB[i] = Convert.ToInt32(Console.ReadLine());
    }  
    double S =0; 
    double SumMathPow =0;   
    for (int i=0; i<ArrayA.Length; i++)
    {
        SumMathPow += Math.Pow(ArrayA[i]-ArrayB[i],2); 
        S = Math.Sqrt(SumMathPow);
    }
    return S;
}
try
{
 Console.WriteLine("Distance between A and B = " +nDimSpace());   
}
catch
{
Console.WriteLine("Please input correctly again!"); 
}
*/