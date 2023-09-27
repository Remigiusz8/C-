namespace Zadanie1
{
    class DataStore<T>
    {
        private T Data;

        public DataStore(T data)
        {
            Data = data;
        }

        public T getData()
        {
            return Data;
        }

        public void setData(T Data)
        {
            this.Data = Data;
        }
    }

    class KeyValuePair<T, U>
    {
        private T Key;
        private U Value;

        public KeyValuePair(T key, U value)
        {
            Key = key;
            Value = value;
        }

        public T getKey()
        {
            return Key;
        }

        public void setKey(T Key)
        {
            this.Key = Key;
        }

        public U getValue()
        {
            return Value;
        }

        public void setValue(U Value)
        {
            this.Value = Value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> data1 = new DataStore<string>("");
            DataStore<int> data2 = new DataStore<int>(2);

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>(4, "Value");
            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>("jeden", "dwa");

            data1.setData("wartość");
            Console.WriteLine(data1.getData());
        }
    }
}