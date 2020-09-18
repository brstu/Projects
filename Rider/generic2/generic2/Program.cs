using System;

namespace generic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Array<T>
    {
        private T[] data;

        public Array()
        {
            data = new T[0];
        }

        //add some date
        public void add(T item)
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }

            newData[data.Length] = item;

            data = newData;
        }

        //delete first found item if he is
        public void remove(T item)
        {
            var index = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                T[] newData = new T[data.Length - 1];
                for (int i = 0, j = 0; i < data.Length; i++)
                {
                    if (i == index)
                        continue;
                    
                    newData[j] = data[i];
                    j++;
                }

                data = newData;
            }
        }
        
        //get item by index
        public T getItem(int index)
        {
            if (index> -1 && index<data.Length)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        //length of data arr
        public int count()
        {
            return data.Length;
        }
    }
}