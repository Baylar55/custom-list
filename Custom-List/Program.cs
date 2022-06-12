using System;
using System.Collections;
namespace Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyList<int> myList = new MyList<int>(7);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Insert(1, 9);
            myList.Clear();
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
