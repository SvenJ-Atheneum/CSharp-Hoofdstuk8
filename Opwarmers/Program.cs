using System.Security.Cryptography;
using static System.Reflection.Metadata.BlobBuilder;

namespace Opwarmers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Opwarmer 1
            int[] getallen = new int[100];
            for (int i = 1; i <= getallen.Length; i++)
            {
                getallen[i-1] = i;
            }
            foreach(int i in getallen) {
                Console.Write(i+",");
            }
            Console.WriteLine();
            Console.WriteLine();
            //Opwarmer 2
            int[] evenG = new int[50];
            for (int i = 1; i <= evenG.Length; i++) {
                evenG[i-1] = i*2;
                Console.Write(evenG[i-1]+",");
            }

            // Opwarmer 3
            int[] drieG = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Geef {i+1} de getal:");
                int j = Convert.ToInt32(Console.ReadLine());
                drieG[i] = j;
            }
            foreach (int i in drieG)
            {
                Console.WriteLine(i);
            }

            string[] namen = { "Tom", "Jef", "Ann", "Julie" };
            foreach (string n in namen) Console.Write(n + ", ");
            Console.WriteLine();
            Console.WriteLine();
            bool[] bools = new bool[20];
            for (int i = 0; i < bools.Length; i++)
            {
                bools[i] = i%2==0;
            }
            foreach(bool b in bools) { Console.Write(b + ", "); }*/

            bool[] bools2 = new bool[20];
            Random random = new Random();
            for(int i = 0; i < bools2.Length; i++){
                int g = random.Next(2);
                bools2[i] = Convert.ToBoolean(g);
            }
            foreach (bool b in bools2) { Console.Write(b + ", "); }
            int tellerTrue = 0, tellerFalse = 0;
            foreach (bool b in bools2)
            {
                if (b) { tellerTrue++; }
                else { tellerFalse++; }
            }
            Console.WriteLine($"aantal True = {tellerTrue} en aantal False = {tellerFalse}");
        }
    }
}
