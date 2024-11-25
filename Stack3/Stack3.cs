using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };

// Виведемо початковий масив
Console.WriteLine("Початковий масив: " + string.Join(", ", array));

// Сортуємо масив за допомогою стеку
int[] sortedArray = SortUsingStack(array);

// Виведемо відсортований масив
Console.WriteLine("Відсортований масив: " + string.Join(", ", sortedArray));

static int[] SortUsingStack(int[] array)
{
    Stack<int> sortedStack = new Stack<int>(); // Стек для відсортованих елементів

    foreach (int value in array)
    {
        // Переносимо елементи у тимчасовий стек, доки не знайдемо позицію для вставки
        Stack<int> tempStack = new Stack<int>();

        // Знімаємо зі стеку, доки верхній елемент більший за поточний `value`
        while (sortedStack.Count > 0 && sortedStack.Peek() > value)
        {
            tempStack.Push(sortedStack.Pop());
        }

        // Вставляємо поточний елемент у відсортований стек
        sortedStack.Push(value);

        // Повертаємо всі елементи з тимчасового стеку назад у відсортований стек
        while (tempStack.Count > 0)
        {
            sortedStack.Push(tempStack.Pop());
        }
    }

    // Перетворюємо відсортований стек у масив і повертаємо його у правильному порядку
    int[] sortedArray = sortedStack.ToArray();
    Array.Reverse(sortedArray); // Стек містить елементи в зворотному порядку

    return sortedArray;
}