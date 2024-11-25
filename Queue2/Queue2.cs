using System.Text;


Console.OutputEncoding = Encoding.UTF8;
// Створюємо чергу
Queue<int> queue = new Queue<int>();

// Заповнюємо чергу для тестування
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

// Виводимо початковий вміст черги
Console.WriteLine("Початковий вміст черги:");
DisplayQueue();
// Викликаємо метод Clear для очищення черги
Clear();
Console.WriteLine("\nЧерга після очищення:");
DisplayQueue(); // Перевірка, що черга порожня

// Додаємо один елемент та перевіряємо відображення
queue.Enqueue(40);
Console.WriteLine("\nЧерга після додавання одного елементу:");
DisplayQueue();

// Метод Clear для очищення черги
void Clear()
{
    queue.Clear(); // Використовуємо вбудований метод Clear для Queue<T>
}

// Метод для виведення вмісту черги
void DisplayQueue()
{
    if (queue.Count == 0)
    {
        Console.WriteLine("Черга порожня.");
    }
    else
    {
        Console.WriteLine("Елементи черги: " + string.Join(", ", queue));
    }
}