using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        //result of bracket must not be minus number
        static void Main(string[] args)
        {
            Console.Write("Misali daxil edin : ");
            string issue = Console.ReadLine();
            issue = BracketLoop(issue);

            Console.WriteLine(OperatorLoop(issue));
        }
        static string BracketLoop(string issue)
        {
            while (Regex.IsMatch(issue, "\\("))
            {
                string CopyIssue = issue;
                while (Regex.IsMatch(CopyIssue, "\\("))
                {
                    CopyIssue = Bracket(CopyIssue);
                    if (!Regex.IsMatch(CopyIssue, "\\("))
                    {
                        string z = Direct(CopyIssue);
                        Regex rgx = new Regex("\\([0-9\\+\\-\\*\\/\\%]+\\)");
                        issue = rgx.Replace(issue, z, 1);
                    }
                }
            }
            

            return issue;
        }
        static string Bracket(string issue)
        {
            int bracketIndex = issue.IndexOf("(");
            bracketIndex = bracketIndex+1;
            int breakPoint = 1;
            string bracketIn = "";
            
            for (int i = bracketIndex; i < issue.Length; i++)
            {
                if (issue[i] == '(')
                {
                    breakPoint++;
                    bracketIn = bracketIn + issue[i];
                }
                else if (issue[i] == ')')
                {
                    breakPoint--;
                    if (breakPoint == 0) {
                        break; 
                    }

                    else if (i == (issue.Length - 1))
                    {
                        break;
                    }
                    else
                    {
                        bracketIn = bracketIn + issue[i];
                    }
                }
                else
                {
                    bracketIn = bracketIn + issue[i];
                }
            }
            return bracketIn;
        }

        static string OperatorLoop(string issue)
        {
            while(Regex.IsMatch(issue, "[\\-\\+\\*\\/\\%]"))
            {
                issue = Direct(issue);
            }
            return issue;
        }


        static string Direct(string str)
        {
            string[] Patern = new string[]
            {
                "[0-9]+\\*[0-9]+", "[0-9]+\\/[0-9]+", "[0-9]+\\%[0-9]+", "[0-9]+[\\-\\+][0-9]+"
            };
            for (int i = 0; i < Patern.Length; i++)
            {
                if (Regex.IsMatch(str, Patern[i]))
                {
                    Match split = Regex.Match(str, Patern[i]);
                    string returnOperation = Convert.ToString(Operation(split.Value));
                    Regex rgx = new Regex(Patern[i]);
                    str = rgx.Replace(str, returnOperation, 1);
                    break;
                }
            }
            return str;
        }



        static int Operation(string str)
        {
            Match num1 = Regex.Match(str, "^[0-9]+");
            Match chr = Regex.Match(str, "[-+*/%]");
            Match num2 = Regex.Match(str, "[0-9]+$");
            int a = Convert.ToInt32(num1.Value);
            int b = Convert.ToInt32(num2.Value);
            char chrValue = Convert.ToChar(chr.Value);
            int opr = 0;
            switch (chrValue)
            {
                case '-':
                    opr = a - b;
                    break;
                case '+':
                    opr = a + b;
                    break;
                case '*':
                    opr = a * b;
                    break;
                case '/':
                    opr = a / b;
                    break;
                case '%':
                    opr = a % b;
                    break;
            }
            return opr;
        }
    }
}
