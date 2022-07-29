// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

/*
int StartsWithVowels(string[] words)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

    int count = 0;

    for (int i = 0; i < words.Length; i++)
        for (int j = 0; j < vowels.Length; j++)
        {
            if (words[i].ToLower()[0] == Char.ToLower(vowels[j])) count++;
        }
    return count;
}

string[] sadness = { "Hello", "my", "name", "is", "Igor", "!" };

Console.Write("Number of words that start with a vowel: " + StartsWithVowels(sadness));

*/


//Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] PairwiseUnion(string[] words)
{

    string[] combined = new string[words.Length / 2];

    for (int j = 0, i = 0; i < words.Length; i += 2, j++)
        combined[j] = words[i] + words[i + 1];

    return combined;
}

void ShowString(string[] words)
{
    for (int i = 0; i < words.Length; i++)
        Console.Write($"{words[i]}  ");
    Console.WriteLine();
}

string[] str = { "Hello ", "my", "name ", "is", "Igor", "!"};

ShowString((PairwiseUnion(str)));
