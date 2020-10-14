using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello");
    Console.WriteLine ("Sadman Sakib Khan");

    // program to print the sum of two numbers
    int a=10,b=20;
    int res=a+b;
    Console.WriteLine(res);
  // program to print the sum of two numbers. 
  int res1 = b/a; 
  Console.WriteLine(res1);

  //4.program to print the result of the following operations. 
  Console.WriteLine ("Output of program number 4:");
  Console.WriteLine( -5 + 8 * 6 );
  Console.WriteLine(  (55+9) % 9  );
  Console.WriteLine( 20 + -3*5 / 8  );
  Console.WriteLine( 5 + 15 / 3 * 2 - 8 % 3 );

   //5.program to print the sum (addition), multiply, subtract, divide and remainder of two numbers.
    Console.WriteLine ("Output of program number 5:");
   Console.WriteLine(a+b);
   Console.WriteLine(b-a);
   Console.WriteLine(a*b);
   Console.WriteLine(b/a);

   //6. Write a program to compute the specified expressions and print the output. 
    double res2 =  ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
   Console.WriteLine("Expression: ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)) = " + res2);
   
  //7.. Write a program to print the area and perimeter of a rectangle.
  double Width = 5.5,Height = 8.5;
  Console.WriteLine("Area is 5.6 * 8.5 = " + (Width*Height));
  Console.WriteLine("Perimeter is 2 * (5.6 + 8.5) =  " + (2*(Width+Height)));

   
  }
}