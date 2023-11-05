using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal class CustomList<Type>
    {
        public Type[] list= new Type[0];
        public int Count { get; private set; } = 0;
        public int Capacity { get; set; } = 5;

        public CustomList()
        {

        }
        public CustomList(int capacity)
        {
            Capacity = capacity <= 0 ? 5 : capacity;
        }
        public CustomList(int capacity, params Type[] arr) : this(capacity)
        {
            list = arr;
            Count = arr.Length;
        }
       
        public void Add(Type a)
        {
            if (Count == list.Length)
            {
                Array.Resize(ref list, Count + Capacity);
            }
            list[Count++] = a;

        }
        public void Clear()
        {
            Count = 0;
        }
        public void Remove(Type a)
        {
            if (!Exist(a))
            {
                throw new Exceptions("Not found!");
            }
            else
            {
                
            for (int i=0;i<Count; i++)
            {
                if (list[i].Equals(a))
                {
                    Count--;
                    Type[] listtemp = new Type[Count];
                    for (int k = 0; k < i; k++)
                    {
                        listtemp[k] = list[k];
                    }
                    for (int k = i; k < Count; k++)
                    {
                        listtemp[k] = list[k+1];
                    }
                    for(int u = 0; u < Count; u++)
                    {
                        list[u] = listtemp[u];

                    }
                    Console.WriteLine("first "+a+" is deleted.");
                    break;
                }
            }
            }
        }
        public void Reverse()
        {
            Type[] listtempp = new Type[Count];

            for (int i = 0; i < Count; i++)
            {
                listtempp[i] = list[Count-1-i];

            }
            list = listtempp;
        }
        public int IndexOf(Type? a)
        {
            if (!Exist(a))
            {
                throw new Exceptions("Not found!");
            }
            else
            {

                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i].Equals(a))
                    {
                        return i;
                    }

                }
                return -1;
            }
        }

        public int LastIndexOf(Type? a)
        {
            if (!Exist(a))
            {
                throw new Exceptions("Not found!");
            }
            else
            {

                int j = -1;
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i].Equals(a))
                    {
                        j = i;
                    }

                }
                return j;
            }
        }
        public bool Exist(Type? a) 
        {
            foreach (var item in list)
            {
                if (item.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }
        public void PrintArray()
        {
            for (int i=0;i<Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
