using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of item");
    string item=Console.ReadLine();
    Console.WriteLine("Enter the quantity");
    int quan=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the price");
    double price=Convert.ToDouble(Console.ReadLine());
    double cost=quan*price;
    Console.WriteLine("Total price of "+item+"= $"+cost);
  }
}