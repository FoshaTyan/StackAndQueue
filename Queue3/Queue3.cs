using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Створюємо чергу
        QueueWithoutCount<int> queue = new QueueWithoutCount<int>();

        // Заповнюємо чергу для тестування
        queue.Insert(10);
        queue.Insert(20);
        queue.Insert(30);

        // Виводимо початковий вміст черги
        Console.WriteLine("Початковий вміст черги:");
        queue.DisplayQueue();

        // Очищаємо чергу
        queue.Clear();
        Console.WriteLine("\nЧерга після очищення:");
        queue.DisplayQueue();

        // Додаємо один елемент і перевіряємо відображення
        queue.Insert(40);
        Console.WriteLine("\nЧерга після додавання одного елементу:");
        queue.DisplayQueue();
    }
}

// Реалізація черги без лічильника
public class QueueWithoutCount<T>
{
    private Node<T> head;
    private Node<T> tail;

    // Вставка елемента в кінець черги
    public void Insert(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;

        if (head == null)
        {
            head = newNode;
        }
    }

    // Видалення елемента з початку черги
    public T Remove()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Черга порожня");
        }

        T value = head.Value;
        head = head.Next;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }

    // Очищення черги
    public void Clear()
    {
        head = null;
        tail = null;
    }

    // Виведення вмісту черги
    public void DisplayQueue()
    {
        if (head == null)
        {
            Console.WriteLine("Черга порожня.");
            return;
        }

        Node<T> current = head;
        Console.Write("Елементи черги: ");
        while (current != null)
        {
            Console.Write(current.Value + (current.Next != null ? ", " : ""));
            current = current.Next;
        }
        Console.WriteLine();
    }

    // Внутрішній клас вузла черги
    private class Node<U>
    {
        public U Value { get; }
        public Node<U> Next { get; set; }

        public Node(U value)
        {
            Value = value;
            Next = null;
        }
    }
}