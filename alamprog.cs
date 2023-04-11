using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv22
{
    public class alamprog
    {
        public static string Kolmarv(int arv1)
        {
            string ans = null;
            for (int x=0; x!=arv1; x++) 
            {
                ans = ans + "*";
            }
            return ans;
        }
        public static string Nurrcalc(int arv1, int arv2, char tehe) 
        {
            string var=null;
            int vastus = 0;
            switch (tehe)
            {
                case '+':
                    vastus = arv1 + arv2;
                    break;
                case '-':
                    vastus = arv1 - arv2;
                    break;
                case '*':
                    vastus = arv1 * arv2;
                    break;
                case '/':
                    if (arv2>arv1) { Console.WriteLine("vale numbrid"); }
                    else{ vastus = arv1 / arv2; }
                    
                    break;
            }
            for (int x = 0; x!=vastus; x++)
            {
                var=var + "nurr ";
            }
            return var;
        }
        public static void Tarnid(int kuipal) 
        { 
            for (int x = 0; x!=kuipal; x++) { Console.Write("*"); }
        }
        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        public  static void Tere(string name)
        {
            Console.WriteLine("Tere {0}",name);
        }
    }
}
