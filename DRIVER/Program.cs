using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriorityQueue;

namespace DRIVER
{
    class Program
    {
        static void Main(string[] args)
        {
            var priorityQueue = new PriorityQueue<Test>();

            priorityQueue.Enqueue(new Test(5));
            priorityQueue.Enqueue(new Test(2));

            Test highestPriorityItem = priorityQueue.Dequeue(); // Verifica che restituisca 5

        }

        public class Test : IComparable<Test>
        {
            private int _tipo;

            public Test(int tipo) => Tipo = tipo;

            public int Tipo { get => _tipo; set => _tipo = value; }

            public int CompareTo(Test other)
            {
                return this.Tipo.CompareTo(other.Tipo);
            }
        }
    }
}
