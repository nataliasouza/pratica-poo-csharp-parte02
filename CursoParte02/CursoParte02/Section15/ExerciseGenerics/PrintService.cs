//Solução com generics

//Deseja - se fazer um programa que leia um conjunto de N números inteiros (N de1 a 10),
//e depois imprima esses números de forma organizada conformeexemplo. Em seguida, informar
//qual foi o primeiro valor informado

namespace CursoParte02.Section15.ExerciseGenerics
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Não é possível adicionar mais elementos");
            }
            _values[_count] = value;
            _count++;
        }

        public T FirstElement()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Não existe elemento! ");
            }

            return _values[0];
        }

        public void PrintElements()
        {
            Console.Write("[");

            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }

            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.Write("]");
        }
    }
}
