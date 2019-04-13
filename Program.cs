using System;
using System.Collections.Generic;

namespace binary
{
    class Program
    {
        static void Main(string[] args)
        {
             var rand = new Random();
             var rngList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                rngList.Add(rand.Next(1000));
            }

            var tree = new Tree();

            for(int x=0; x < rngList.Count; x++)
            {
                tree.Insert(rngList[x]);
            }
 

            Console.WriteLine("find a number");
            var num = int.Parse(Console.ReadLine());

            tree.Search(num);

            tree.OrderTree(tree);
          

            Console.ReadLine();
        }

    }


}
