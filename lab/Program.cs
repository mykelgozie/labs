using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {

        int  num = 200;

            string check = "";


            if ( num < 0)
            {

              Console.WriteLine("invalid");


            }

            for (int i = 1; i <= num; i++)
            {


                if (i % 3 == 0 && i % 5 == 0)
                {

                    check = check + "\nfizzbuzz";


                }
                else if (i % 3 == 0)
                {


                    check = check + "\nfizz";

                }
                else if (i % 5 == 0)
                {

                    check = check + "\nbuzz";

                }
                else if (i % 3 != 0 || i % 5 != 0)
                {


                    check = check + "\n" + i;

                }



            }


            Console.WriteLine(check);






        }
    }
}
