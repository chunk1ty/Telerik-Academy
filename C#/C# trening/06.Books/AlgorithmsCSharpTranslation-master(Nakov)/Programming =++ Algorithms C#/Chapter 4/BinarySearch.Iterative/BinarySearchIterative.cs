﻿using System;
using System.Text;

class BinarySearchIterative
{
    public class Element<T>
    {
        public int Key { get; set; }
        public T Value { get; set; }

        public Element(int key, T value)
        {
            this.Key = key;
            this.Value = value;
        }
    }

    static Random random = new Random();         // Генератор на произволни числа.
    const int MaxValue = 50;                    // Максимална стойност на елементите от масива.
	const int NotFound = -1;

    static void SortElementsArray(Element<int>[] elements)        // Сортира елементите в масива.
    {
        for (int i = 0; i < elements.Length; i++)
            for (int j = 0; j < elements.Length; j++)
                if (elements[i].Key < elements[j].Key)
                {
                    var swapElement = elements[i];
                    elements[i] = elements[j];
                    elements[j] = swapElement;
                }
    }

    static int BinarySearch(Element<int>[] elements, int elementToSearch)     // Извърша двоично търсене.
    {
        int leftIndex = 0;
        int rightIndex = elements.Length - 1;
        int midIndex;
        int result = NotFound;
        while (leftIndex <= rightIndex)
        {
            midIndex = (leftIndex + rightIndex) / 2;
            if (elementToSearch < elements[midIndex].Key)
                rightIndex = midIndex - 1;
            else if (elementToSearch > elements[midIndex].Key)
                leftIndex = midIndex + 1;
            else
            {
                result = midIndex;
                break;
            }
        }
        return result;
    }

    static void PrintElements(Element<int>[] elements)        // Принтира елементите на масива върху конзолата.
    {
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < elements.Length; i++)
        {
            output.Append(elements[i].Value);
            if (i < elements.Length - 1)
                output.Append(",");
        }
        Console.WriteLine(output.ToString());
    }

    public static void PerformSearchTest(Element<int>[] elements, int n)
    {
        int index;
        for (int elementToSearch = 0; elementToSearch < 2 * MaxValue; elementToSearch++)
        {
            Console.WriteLine("Търсим елемент с ключ {0}.", elementToSearch);
            index = BinarySearch(elements, elementToSearch);
            if (index == NotFound)
                Console.WriteLine("Елемент с такъв ключ не съществува!");
            else
                Console.WriteLine("Елементът е намерен! Стойност на инф. част: {0}.", index);
        }
    }

    static void Main()
    {
        int n = MaxValue;                                                    // Брой елементи в масива.
        Element<int>[] elements = new Element<int>[n];                  // Инициализация на масив със записи.
        for (int index = 0; index < n; index++)
        {
            int randomNumber = random.Next(0, 2 * MaxValue);
            elements[index] = new Element<int>(randomNumber, index);     // Пълнене на масива с произволни числа.
        }

        SortElementsArray(elements);

        Console.WriteLine("Списъкът съдържа следните елементи: ");
        PrintElements(elements);

        Console.WriteLine("\nТестване:");
        PerformSearchTest(elements, n);
    }
}
