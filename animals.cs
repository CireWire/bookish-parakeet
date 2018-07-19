using System;

class MainClass 
{
  class Animal                  //Setting up the Animal base class
  {
    public int Legs {get; set;}
    public int Age {get; set;}
  }

  class Cat : Animal        //Inheriting the Animal base class for the "Cat" class
  {
    public Cat()
    {
      Legs = 4;
    }
    public void Meow()
    {
      Console.WriteLine("Meow!");
    }
  }
  
  class Cow : Animal      //Inheriting the Animal base class for the "Cow" class
  {
    public Cow()
    {
      Legs = 4;
    }
    public void Moo()
    {
      Console.WriteLine("Mooooo!");
    }
  }
  public static void Main (string[] args) 
  {
    Cat c = new Cat();
    Console.WriteLine(c.Legs);
    c.Meow();

    Cow co = new Cow();
    Console.WriteLine(co.Legs);
    co.Moo();
  }
}
