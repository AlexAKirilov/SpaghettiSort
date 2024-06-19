﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Входные данные, массив чисел для сортировки
        var numbersToSort = new[] {1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, 1, 2, 3, 4, 5, 56565, 343, 65, 5654, 3434, 76, 8787, 565, 45, 4545, };

        // Создание словаря для группировки чисел по их значению
        var spaghetti = new Dictionary<int, List<int>>();
        var maxNumber = 0;
        var ifCount = 0;

        // Группировка чисел по их значению
        foreach (var number in numbersToSort)
        {
            maxNumber = Math.Max(number, maxNumber); // Определение максимального значения числа
            ifCount += 1;
            
            ifCount += 1;
            if (!spaghetti.ContainsKey(number))
            {
                spaghetti[number] = new List<int>(); // Создание нового списка, если такой группы еще нет в словаре
            }
            spaghetti[number].Add(number); // Добавление числа в соответствующий список
        }

        // Подготовка конечного отсортированного списка
        var result = new List<int>();
        for (var value = maxNumber; value >= 0; value--) // Итерация от максимального значения к нулю
        {
            ifCount += 1;
            if (spaghetti.ContainsKey(value))
            {
                result.AddRange(spaghetti[value]); // Добавление всех чисел данного значения в результат
            }
        }

        // Вывод результата
        Console.WriteLine(string.Join(", ", result)); // Печать чисел через запятую
        Console.WriteLine();
        Console.WriteLine("Array length = " + numbersToSort.Length);
        Console.WriteLine("ifCount = " + ifCount);
        Console.ReadLine(); // Ожидание ввода от пользователя, чтобы консольное окно не закрылось сразу
    }
}