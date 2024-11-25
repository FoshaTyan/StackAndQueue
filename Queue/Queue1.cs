using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// Запитуємо у користувача значення n та k
Console.Write("Введіть кількість елементів в черзі (n): ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введіть кількість елементів для витягання (k): ");
int k = int.Parse(Console.ReadLine());

// Створюємо та заповнюємо чергу випадковими числами
Queue<int> queue = CreateRandomQueue(n);

// Виводимо початковий вміст черги
Console.WriteLine("\nПочаткова черга: " + string.Join(", ", queue));

// Витягаємо та виводимо перші k елементів
Console.WriteLine($"\nПерші {k} елементів:");
for (int i = 0; i < k && queue.Count > 0; i++)
{
    Console.WriteLine(queue.Dequeue());
}

// Виводимо залишок черги
Console.WriteLine("\nЧерга після витягання елементів: " + string.Join(", ", queue));

static Queue<int> CreateRandomQueue(int n)
{
    Queue<int> queue = new Queue<int>();
    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        queue.Enqueue(random.Next(1, 101)); // Додаємо випадкове число від 1 до 100
    }

    return queue;
}