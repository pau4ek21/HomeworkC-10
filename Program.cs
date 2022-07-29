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

string[] sadness = { "I", "don,t", "to", "say", "goodbye", ":(" };

Console.Write("Number of words that start with a vowel: " + StartsWithVowels(sadness));