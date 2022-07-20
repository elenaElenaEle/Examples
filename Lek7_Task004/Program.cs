// Перебор слов
// В некотором машинном алфавите имеются 4 буквы "а", "и", "с", "в". Покажите все слова, состоящие из Т букв этого алфавита. 
// итерративно 
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
/* for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++) /// двубеквенные = T
    {
        for (int k = 0; k < count; k++) // трехбуквенные = T
        {
            Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}"); // однобуквенные слова 1 цикл фор. для двубеквенных еще один фор выше и добавляем {s[j]}. - 5 задает пробелы
        }
    }
} */

// рекурсия


void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

Console.WriteLine("Рекурсия");
 FindWords("аисв", new char[3]);


