using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab1
            /*intArray[i][i] = r.Next(0, 20);*/

            /*  Random r = new Random();
              int[][] intArray = new int[3][];
              for(int i = 0; i < intArray.Length; i++) {
                  intArray[i] = new int[5];
                  for(int j = 0; j < intArray[i].Length; j++)
                  {

                      intArray[i][j] = r.Next(0, 20);
                  }

              };
              for (int i = 0; i < intArray.Length; i++)
              {
                  Console.Write("Element({0}): ", i);

                  for (int j = 0; j < intArray[i].Length; j++)
                  {
                      Console.Write("{0}{1}", intArray[i][j], j == (intArray[i].Length - 1) ? "" : " ");
                  }
                  Console.WriteLine();
              }
              Console.ReadLine();*/
            #endregion
            #region Lab2
            int sizear = 6;
            Random r = new Random();
            int[][] intArray = new int[4][];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = new int[sizear];
                for (int j = 0; j < intArray[i].Length; j++)
                {

                    intArray[i][j] = r.Next(0, 20);

                }
                sizear--;
                if (sizear == 3) { sizear--; };
            };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(i);

                for (int j = 0; j < intArray[i].Length; j++)
                {
                    Console.Write("{0}{1}", intArray[i][j], j == (intArray[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            #endregion
        }
    }
}
