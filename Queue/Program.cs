// See https://aka.ms/new-console-template for more information

using Queue;

IQueueCustom<int> queue = new QueueCustom<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

Console.WriteLine("Enter to exit");