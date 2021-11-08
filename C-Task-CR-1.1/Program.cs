using System;

namespace C_Task_CR_1._1
{
    class Program
    {
        static void Main(string[] args)
        {


            /*  int[] Arry = { };*/

            //int a = Convert.ToInt32(Console.ReadLine());
            #region Task-1
            int[] Arry = new int[0];

            for (var i = 0; i < 5; i++)
            {
                /*if (Arry == null)
                    Arry = new int[1];*/

                /*  else*/
                int a = Convert.ToInt32(Console.ReadLine());

                Array.Resize(ref Arry, Arry.Length + 1);

                Arry[Arry.Length - 1] = a;

                Console.WriteLine("=-----------------------");


            }
            for (int i = 0; i < Arry.Length; i++)
            {
                Console.WriteLine(Arry[i]);
            }

            #endregion

            #region Task-2
                
            #endregion

        }

    }
}
