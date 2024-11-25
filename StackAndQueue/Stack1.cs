using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// Введення рядка користувачем
Console.WriteLine("Введіть рядок, що містить символи і числа:");
string input = Console.ReadLine();

// Ініціалізація стеків для символів та чисел
Stack<char> charStack = new Stack<char>();
Stack<int> numberStack = new Stack<int>();

// Обробка кожного символу у рядку
foreach (char c in input)
{
    if (char.IsDigit(c))
    {
        // Додавання чисел до стеку чисел
        numberStack.Push(int.Parse(c.ToString()));
    }
    else if (char.IsLetter(c))
    {
        // Додавання символів до стеку символів
        charStack.Push(c);
    }
}

// Виведення вмісту стеків
Console.WriteLine("Стек символів:");
while (charStack.Count > 0)
{
    Console.Write(charStack.Pop() + " ");
}

Console.WriteLine("\nСтек чисел:");
while (numberStack.Count > 0)
{
    Console.Write(numberStack.Pop() + " ");
}
//проверка на конец и пустой стек