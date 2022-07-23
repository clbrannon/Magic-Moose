using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Moose;


public static class Moose


{
    static Random rand = new Random();


    public static void Response()
    {
        int nbr = 0;
        nbr = rand.Next(1,7);
            
        if (nbr == 1)  
        {
            Console.WriteLine("As I see it, yes.");
        }

        else if (nbr == 2)
        {
            Console.WriteLine("Ask again later.");
        }
        else if (nbr == 3)
        {
            Console.WriteLine("Better not tell you now");
        }
        else if (nbr == 4)
        {
            Console.WriteLine("Don’t count on it.");
        }
        else if (nbr == 5)
        {
            Console.WriteLine("It is certain.");
        }
        else
        {
            Console.WriteLine("Without a doubt");
        }
    }
}
