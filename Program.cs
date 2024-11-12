using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
     class Program
    {
        static void Main(string[] args)
       { int rafin = 30;
            float maliha = 20.05F;
            double f = 44.5D;
            bool isGreat = true;
            char A ='F';     
            double y = A;                                                     // implicit type casting 
            int t = 'y';
            int r = (int)20.05;                                              //explicit typecasting
            float i = Convert.ToInt64(20.05);                               //type casting in build c sharp
            String s = "laughing out loud";
            Console.WriteLine("Hello world");                              //single line argument
            Console.WriteLine("never mind ");
            Console.WriteLine(1 + 1);                                      /* Here  my heart lies
                                                                             and  this is multi-line comment*/
           Console.WriteLine("where am i going ?");
            Console.WriteLine("i am interested in programming hahaha");
            Console.WriteLine(" going dedicated hehehehehehhe");
            Console.WriteLine(100-100);
            Console.Write("thats the mark i got lol in life" + rafin);
            Console.WriteLine("haha");
            Console.WriteLine(rafin - maliha + f);
            Console.WriteLine (s);
            Console.WriteLine (rafin);
            Console.WriteLine(isGreat);
            Console.WriteLine(A);
            Console.WriteLine(y);
            Console.WriteLine(r);
           
            Console.WriteLine("Hello , how can I help you? enter you name ....");
            string st = Console.ReadLine();
            Console.WriteLine("Hello " + st);

           Console.WriteLine("How many  stars you want ?");
            string stt = Console.ReadLine();
            Console.WriteLine("Never mind you will  have more 8 , your total stars will be .." + (Convert.ToInt32(stt) + 8));
            Console.WriteLine("Are you happy with our service !");
           string sttt = Console.ReadLine();
            Console.WriteLine("ThankS for your valuable opinion...");

            Console.WriteLine("The value is =" + ((rafin + f)-maliha));  //arithmetic operator
            
            int d = rafin;         //assignment operator
            float n = maliha;
            n -= 10;
            d += 8;

            Console.WriteLine( n);
            Console.WriteLine(d);

            Console.WriteLine(true&&true);         //logical operators
            Console.WriteLine(true&&false);
            Console.WriteLine(false&&false);

            Console.WriteLine(true||true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            Console.WriteLine(!false);
            Console.WriteLine(!true);

           Console.WriteLine(44 < 4);          //comparison operator
            Console.WriteLine(55 > 555);
            Console.WriteLine(555<=5);
            Console.WriteLine(44>=99);
            Console.WriteLine(22!=44);
            Console.WriteLine(5==5);

         
           int cc = Math.Min(444, 44);
            Console.WriteLine(cc); 
           
            Console.WriteLine("Your age for marriage ?");
            string gender =  Console.ReadLine() ;
            int age = Convert.ToInt32(gender);
            
          if (age > 21)
            {
                Console.WriteLine("eligable");
            }
            else if (age < 18)
            {
                Console.WriteLine("eligable but you should wait");
            }
            else if (age < 10)
                    {
                Console.WriteLine("you are minor");
                    }

            else 
            { 
                Console.WriteLine("ineligable");
            }         
          
          
          /* Console.WriteLine(
            Console.WriteLine(
            Console.WriteLine(
            Console.WriteLine*/



            Console.ReadLine(); 
            
        }   
    }
}

