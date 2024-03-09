// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{

    int[] Array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

    PrintArr(Array);

    void PrintArr(int[] Array)
    {
        if(Array.Length == 0) return;
        else
        {
            //Console.Write(" "+ Array[0]);
            PrintArr(Array.Skip(1).ToArray());
            Console.Write(" "+ Array[0]);
        }
    }

}

Main();