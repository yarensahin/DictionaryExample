using System;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(963, "Esra");
            myDictionary.Add(112, "Faruk");
            myDictionary.Add(587, "Fahriye");

            myDictionary.Display();
        }
    }
}
