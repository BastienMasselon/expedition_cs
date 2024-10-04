using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace expedition_cs
{
    internal class Program
    {

        static void Main()
        {
            List<string> stringCollection = new List<string>();
            stringCollection.Add("Hey");
            stringCollection.Add("Hello");
            stringCollection.Add("On dit quoi ?");
            Console.WriteLine(stringCollection[1]);
            stringCollection.RemoveAt(0);
            stringCollection.Remove("On dit quoi ?");
            stringCollection[0] = "Il reste plus que moi :(";
            Console.WriteLine(stringCollection[0]);
        }
    }
}
