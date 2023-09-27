using System;

namespace QueueClass
{
    public class Queue
    {
        static readonly int MAX = 1000;
        int top = -1;
        int[] queue = new int[MAX];

        public bool Enqueue(int data)
        {
            if(top >= MAX)
            {
                Console.WriteLine("Queue Overflow!");
                return false;
            }

            top++;
            queue[top] = data;
            return true;
        }

        public int Dequeue()
        {
            if(top < 0)
            {
                Console.WriteLine("Queue Underflow!");
                return 0;
            }

            int valor = queue[0];

            for(int i = 1; i <= top; i++)
            {
                queue[i-1] = queue[i];
            }

            return valor;
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Queue Underflow!");
                return;
            }

            Console.WriteLine($"O proximo elemento é: {queue[0]}");
        }

        public void PrintList()
        {
            if(top < 0)
            {
                Console.WriteLine("Queue Underflow!");
                return;
            }

            Console.WriteLine("Itens da Fila:");
            for(int i = 0; i <= top; i++)
            {
                string texto = $"Queue[{queue[i]}]";
                Console.WriteLine(texto);
            }
        }
    }
}
