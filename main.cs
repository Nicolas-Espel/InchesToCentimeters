using System;

class Program {
  public static void Main (string[] args) {
    const double CentimetersInAnInch = 2.54;
    
    var inches = 15994;

    var conversion = inches * CentimetersInAnInch;
    Console.WriteLine("{0} inches is {1} centimeters.", inches, conversion);
    
  }
}