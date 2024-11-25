using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<int> queue = new List<int>();
List<int> priority = new List<int>();

Console.WriteLine("Додайте елементи в чергу з пріоритетом. Введіть 'end' для завершення.");

while (true)
{
    Console.Write("Введіть значення елемента ('end' для завершення): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "end")
    {
        break;
    }

    if (int.TryParse(input, out int element))
    {
        Console.Write("Введіть пріоритет для цього елемента: ");
        string priorityInput = Console.ReadLine();

        if (int.TryParse(priorityInput, out int prio))
        {
            queue.Add(element);
            priority.Add(prio);
        }
        else
        {
            Console.WriteLine("Неправильний пріоритет. Спробуйте ще раз.");
        }
    }
    else
    {
        Console.WriteLine("Неправильний елемент. Спробуйте ще раз.");
    }
}

Console.WriteLine("\nЧерга перед обробкою:");
PrintQueue(queue, priority);

Console.WriteLine("\nВиведення черги з урахуванням пріоритету:");

while (queue.Count > 0)
{
    int highestPriorityIndex = FindHighestPriorityIndex(priority);

    Console.WriteLine($"Елемент: {queue[highestPriorityIndex]}, Пріоритет: {priority[highestPriorityIndex]}");

    queue.RemoveAt(highestPriorityIndex);
    priority.RemoveAt(highestPriorityIndex);
}

static void PrintQueue(List<int> queue, List<int> priority)
{
    for (int i = 0; i < queue.Count; i++)
    {
        Console.WriteLine($"Елемент: {queue[i]}, Пріоритет: {priority[i]}");
    }
}

static int FindHighestPriorityIndex(List<int> priority)
{
    int highestPriorityIndex = 0;
    for (int i = 1; i < priority.Count; i++)
    {
        if (priority[i] < priority[highestPriorityIndex])
        {
            highestPriorityIndex = i;
        }
    }
    return highestPriorityIndex;
}