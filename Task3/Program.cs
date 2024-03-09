// задача 3. считать строку с консоли, состоящую из
// цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.
// Этапы решения:
// 1 ввод строки 123pasaw0rd
// 2 проход по всем элементам строки
// 3 проверка элемента: является ли он буквой?
// используем метод is letter?
// 4 дописать подходящий элемент к новой строке

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
System.Console.WriteLine(result);
