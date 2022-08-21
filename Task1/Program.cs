﻿// Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
//Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:

void PrintSequence(int N, int counter = 0, int start = 0)
{
    for (int i = 0; i < start; i++)
    {
        counter++;
        Console.Write($"{start}, ");
        if (counter == N) return;
    }
    PrintSequence(N, counter, start + 1);

}

PrintSequence(12);

