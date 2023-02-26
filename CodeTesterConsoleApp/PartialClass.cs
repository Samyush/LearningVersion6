namespace CodeTesterConsoleApp;

public partial  class PartialClass
{
  public static void tester()
  {
    Console.WriteLine("TEST");
  }  
}

public partial class PartialClass
{
  //partial class can have same class name but no same method name
  /*void tester()
  {
    Console.WriteLine("TEST");
  }  */

  static void testerNew()
  {
    Console.WriteLine("TEST");
  }  
}