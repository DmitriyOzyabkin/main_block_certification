﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//         длина которых меньше, либо равна 3 символам.


void PrintWordsArray(string[] array)
{
    foreach (string elem in array)
    {
        Console.Write(elem + " ");
    }
}

string[] CheckWordLenthInArray(string[] array)
{
    string[] result = new string[0];
    int index = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[index] = item;
            index++;
        }
    }
    return result;
}

// At this block every word adds to array
Console.WriteLine("So, first of all we should create an array with words.");
Console.Write("How many words do you want to enter?: ");

int wordsAmount = Convert.ToInt32(Console.ReadLine());
string[] wordsList = new string[wordsAmount];
Console.WriteLine("Please, enter your words one by one.");

for (int i = 0; i < wordsAmount; i++)           // Add words to array
{
    Console.Write($"Enter word {i + 1}: ");
    wordsList[i] = Console.ReadLine();
}

string[] resultArray = CheckWordLenthInArray(wordsList);


PrintWordsArray(resultArray);


