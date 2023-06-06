using System;

namespace Generics
{
    class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)   // Significa que a variável já está cheia
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            if (_count == 0)   // Significa que a variável está vazia
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");

            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");       // Imprime do 0 ao 8 (penúltimo valor)
            }

            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);     // Imprime o último valor (posição 9)
            }

            Console.WriteLine("]");
        }
    }
}
