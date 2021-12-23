// See https://aka.ms/new-console-template for more information

using Stack;


IStackCustom<int> stack = new StackCustom<int>();

stack.Push(1);
stack.Push(4);
stack.Push(9);

System.Console.WriteLine(stack.Peek());

System.Console.WriteLine("Pop: " + stack.Pop());
System.Console.WriteLine("Pop: " + stack.Pop());
System.Console.WriteLine("Pop: " + stack.Pop());
System.Console.WriteLine("Pop: " + stack.Pop()); // Exception

