// 74. В некотором машинном алфавите имеются четыре буквы «а», «b», «с» и «d». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

int n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++}\t{ new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("abcd", new char[3]);
