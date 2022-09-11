using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int foodForCat = 4;
      bool hatinShop = true;
      char letterofFirstName = 'G';
      string popSong = "Toxic";
      float percentage = 0.40f;
      
      
      if (foodForCat >= 2) 
      {
        Console.WriteLine("You don't need to buy Catfood right not.");
      }   
      
      if (hatinShop == true) 
      {
        Console.WriteLine("We have the Hat you wanted in the shop today!");
      }
      
      if (letterofFirstName != 'a') 
      {
        Console.WriteLine("You're name was not called.");
      }
      
      if (popSong == "Toxic") 
      {
        Console.WriteLine("Now playing Toxic by Britney Spears is now playing.");
      }
      
      if (percentage <= 0.50f) 
      {
        Console.WriteLine("There is less than 50%.");
      }
    }
  }
}
