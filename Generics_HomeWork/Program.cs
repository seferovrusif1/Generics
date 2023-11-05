namespace Generics_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CustomList<int> list = new CustomList<int>(8,1,2,3);
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            Console.WriteLine("Print Array");
            list.PrintArray();

            Console.WriteLine("last index '1'");
            Console.WriteLine(list.LastIndexOf(1));

            Console.WriteLine("FIRST index '1'");
            Console.WriteLine(list.IndexOf(1));
            try
            {
            list.Remove(29);
            }
            catch(Exceptions e) 
            { Console.WriteLine(e.Message); }
            try
            {
                list.IndexOf(29);
            }
            catch (Exceptions e)
            { Console.WriteLine(e.Message); }
            Console.WriteLine("Print Array");
            list.PrintArray();          
            Console.WriteLine("first index of '2': "+list.IndexOf(2));
            Console.WriteLine("reverse and print");
            list.Reverse();
            list.PrintArray();
            list.Clear();
            list.PrintArray();
            Console.WriteLine(list.Exist(1));
            //bool iscontunie = true;
            //while (iscontunie)
            //{
            //    Console.WriteLine("1. Add():\n2. Clear():\r\n3. bool Exist()\r\n4. Remove()\r\n5. Reverse()\r\n6. IndexOf()\r\n7. LastIndexOf()\n8. Quit");
            //    string a = Console.ReadLine();
            //    switch (a)
            //    {
            //        case "1":
            //            break;
            //        case "2":
            //            break;
            //        case "3":
            //            break;
            //        case "4":
            //            break;
            //        case "5":
            //            break;
            //        case "6":
            //            break;
            //        case "7":
            //            break;
            //        case "8":
            //            break;
            //    }
            //}
        }
    }
}