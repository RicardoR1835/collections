using System;
using System.Collections.Generic;

namespace collectionsprac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            string[] array = new string[10];
            for(int i = 0; i < array.Length; i++){
                if(i % 2 == 0){
                    array[i] = "true";
                } else {
                    array[i] = "false";
                }
            }
            foreach (string b in array){
                Console.WriteLine(b);
            }
            List<string> flavors = new List<string>();
            flavors.Add("mint-chocolate-chip");
            flavors.Add("sherbert");
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("banana");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
            Dictionary<string,string> info = new Dictionary<string,string>();
            info.Add(names[0], flavors[0]);
            info.Add(names[1], flavors[1]);
            info.Add(names[2], flavors[2]);
            info.Add(names[3], flavors[3]);
            foreach (KeyValuePair<string,string> entry in info){
                Console.WriteLine(entry.Key + "---" + entry.Value);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
