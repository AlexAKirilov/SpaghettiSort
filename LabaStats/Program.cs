using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Запрос ввода длины массива и диапазона чисел
        Console.WriteLine("Введите длину массива:");
        int arrayLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите минимальное значение диапазона:");
        int minValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите максимальное значение диапазона:");
        int maxValue = int.Parse(Console.ReadLine());

        // Генерация массива случайных чисел заданной длины и диапазона
        var random = new Random();
        var numbersToSort = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            numbersToSort[i] = random.Next(minValue, maxValue + 1);
        }

        // Создание словаря для группировки чисел по их значению
        var spaghetti = new Dictionary<int, List<int>>();
        var maxNumber = 0;
        var ifCount = 0;

        // Группировка чисел по их значению
        foreach (var number in numbersToSort)
        {
            ifCount += 1;
            maxNumber = Math.Max(number, maxNumber); // Определение максимального значения числа

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

        // Запись в CSV файл
        var csvPath = "output.csv";
        using (var writer = new StreamWriter(csvPath, true))
        {
            writer.WriteLine($"{numbersToSort.Length} {ifCount}");
        }

        Console.WriteLine($"Данные записаны в файл {csvPath}");
        Console.ReadLine(); // Ожидание ввода от пользователя, чтобы консольное окно не закрылось сразу
    }
}
