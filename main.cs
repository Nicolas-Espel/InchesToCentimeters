using System;

class Program {
  public static void Main (string[] args) {
    const double CentimetersInAnInch = 2.54;
    
    Console.WriteLine ("Enter how many inches to convert: ");
    var inches = Convert.ToInt16(Console.ReadLine());

    var conversion = inches * CentimetersInAnInch;
    Console.WriteLine("{0} inches is {1} centimeters.", inches, conversion);
    
  }
}