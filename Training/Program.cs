using System;
using System.Runtime.CompilerServices;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Training
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Console.Write("this is my first program in training !");  -- print the output and stays on the same cursor line
      //Console.WriteLine(); -- print the output and goes to next line
      //Console.Read(); --  read the input and stays on the same cursor line  ,press enter to exit , datatype retrun =int
      // Console.ReadLine();    read the input and goes to next line after reading the text , press enter to exit  , data type retrun = String

      Console.WriteLine("*********this is my first code in training**********");
      Console.WriteLine("1) Example of arithmetic operatiors!!!");
      Console.WriteLine();

      Console.Write("Enter number1 : ");
      int n1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number2 : ");

      int n2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input values are :" + n1 + " and " + n2);

      Console.Write("\nEnter the operator :     ");
      char c1 = Convert.ToChar(Console.ReadLine());

      //if ( c1=='+')
      //{
      //  Console.WriteLine("Result values are :" +(n1+n2));
      //}

      //else if ( c1=='-')
      //{
      //  Console.WriteLine("Result values are :" + (n1 - n2));
      //}

      //else if (c1 == '*')
      //{
      //  Console.WriteLine("Result values are :" + (long)(n1 * n2));
      //}

      //else if (c1 == '/')
      //{
      //  Console.WriteLine("Result values are :" + (float)(n1/n2));
      //}

      //else if (c1 == '%')
      //{
      //  Console.WriteLine("Result values are :" + (float)(n1%n2));
      //}
      //Console.WriteLine("\n2) implicite conversion example)");

      //double d = 11111213322.2522;
      //Console.WriteLine("double data type value :" + d);

      //int x = (int)d;

      //Console.WriteLine("Converted integer value : " + x);
      //char c1;
      //while (true)
      //{
      //  Console.Write("\nEnter the operator : ");
      //   c1 = Convert.ToChar(Console.ReadLine());
      //  switch (c1)
      //  {
      //    case '+':
      //      Console.WriteLine("Result values are :" + (n1 + n2));
      //      break;

      //    case '-':
      //      Console.WriteLine("Result values are :" + (n1 - n2));
      //      break;

      //    case '*':
      //      Console.WriteLine("Result values are :" + (n1 * n2));
      //      break;

      //    case '/':
      //      Console.WriteLine("Result values are :" + ((decimal)(n1 / n2)));
      //      break;

      //    default:
      //      Console.WriteLine("this is default section");
      //      break;
      //  }
      //}



      //for (int i = 0; i<50; i++)

      //{
      //  if (i % 2 == 0)
      //    Console.WriteLine("\nEven numbers " +i);
      //  else
      //    Console.WriteLine("\nOdd numbers " + i);
      //}
      int a = 10;

      do

      { Console.WriteLine("this is do while ");
      } while (a == 11);

      
     
      for (int i = 0; i < 10; i++) 
      
      {
        if (i == 5)
          goto dell;
      }
    dell: Console.WriteLine("this is go to lable");

     
      Console.ReadLine();
    }
  }
}