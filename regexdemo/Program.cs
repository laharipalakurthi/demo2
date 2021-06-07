using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regexdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CallAgain:
                Console.WriteLine("Enter userName : ");
                string userName = Console.ReadLine();



                string smallCharPattern = "^[a-z]+$";
                string capitalCharPattern = "^[A-Z]+$";
                string onlyCharPattern = "^[a-zA-Z]+$";



                string onlyNumberPatter = "^[0-9]+$";



                string alphanumPatter = "^[a-zA-Z0-9]+$";



                string MobilePattern = "^[0-9]{10}$";



                Regex rx = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$"); ;
                Match resVal = rx.Match(userName);



                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(userName);
            if (match.Success)
            {
                Console.WriteLine("Good Email id. ");
            }
            //bool res = Regex.IsMatch(userName, IndianFormatMobilePattern);
            if (resVal.Success)
            {
                Console.WriteLine("Thanks for the userName. ");
            }
            else
            {
                    Console.WriteLine("please Enter a proper userName only with string. ");
                    goto CallAgain;
                }
                Console.ReadLine();
            }
        }
    }

