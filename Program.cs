using System;
namespace arrayy
{
  class Program
  {
    public static void Main(string[]args)
    {

      Console.WriteLine("Quantos quartos quer alugar");
      int x = Convert.ToInt32(Console.ReadLine());
      Quarto[] quartovet = new Quarto[20];

      for (int i=0 ; i < x ; i++)
      {
        Console.WriteLine ($"Rent #{i+1}");
        Console.Write ("Name: ");
        string name = Console.ReadLine();
        Console.Write ("Email: ");
        string email = Console.ReadLine();
        Console.Write ("Room: ");
        int room = Convert.ToInt32(Console.ReadLine());

        quartovet [room] = new Quarto (name,email);
      }

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLine("Busy rooms:");

      for (int i=0 ; i < 10 ; i++)
      {
        if (quartovet[i] != null){
        Console.WriteLine($"{i} : {quartovet[i]}");
        }
      }

    }
  }
}
