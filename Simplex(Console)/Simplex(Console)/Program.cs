using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplex_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            LPP feladat;
            ObjectiveFunction of;
            Constraint cs1;
            Constraint cs2;
            Constraint cs3;
           



            double[] tomb1 = { 5, 4, 3 };

            double[] tombcs1 = {2,3,1};
            double[] tombcs2 = {4,1,2};
            double[] tombcs3 = {3,4,2};

            cs1 = new Constraint(tombcs1,5);
            cs2 = new Constraint(tombcs2,11);
            cs3 = new Constraint(tombcs3,8);

            of = new ObjectiveFunction(tomb1);
            Constraint[] css = { cs1, cs2, cs3 };

            feladat = new LPP(of,css);

            feladat.Solve();

            Console.ReadLine();

        }
    }
}
