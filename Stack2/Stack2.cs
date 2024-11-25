using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// Введення рядка користувачем
Console.WriteLine("Введіть рядок, що містить літери:");
string input = Console.ReadLine();

// Ініціалізація стеків для голосних та приголосних
Stack<char> vowelsStack = new Stack<char>();
Stack<char> consonantsStack = new Stack<char>();

// Оголошення голосних літер
HashSet<char> vowels = new HashSet<char> { 'а', 'у', 'о', 'и', 'э', 'ы', 'я', 'ю', 'е', 'ё' };

// Обробка кожного символу у рядку
foreach (char c in input)
{
    if (char.IsLetter(c))
    {
        if (vowels.Contains(c))
        {
            // Додавання голосних до стеку голосних
            vowelsStack.Push(c);
        }
        else
        {
            // Додавання приголосних до стеку приголосних
            consonantsStack.Push(c);
        }
    }
}

// Виведення вмісту стеків
Console.WriteLine("Стек голосних:");
while (vowelsStack.Count > 0)
{
    Console.Write(vowelsStack.Pop() + " ");
}

Console.WriteLine("\nСтек приголосних:");
while (consonantsStack.Count > 0)
{
    Console.Write(consonantsStack.Pop() + " ");
}