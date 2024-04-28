// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//         длина которых меньше, либо равна 3 символам.


// Enter init words
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




// Test print of all words
foreach (string elem in wordsList)
{
    Console.Write(elem + " ");
}
