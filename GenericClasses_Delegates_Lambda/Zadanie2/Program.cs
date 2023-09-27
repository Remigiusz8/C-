namespace Zadanie2
{
    class DataStore<T>
    {
        private T[] data = new T[10];

        public void AddOrUpdate(int index, T element)
        {
            if(index >= 0 && index < 10)
            {
                data[index] = element;
            }
        }

        public T getData(int index)
        {
            if(index >= 0 && index < 10)
            {
                return data[index];
            }
            else
            {
                return default(T);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> data1 = new DataStore<string>();
            data1.AddOrUpdate(0, "info1");
            data1.AddOrUpdate(1, "infooo2");
            data1.AddOrUpdate(2, "inf3");

            Console.WriteLine(data1.getData(2));
        }
    }
}