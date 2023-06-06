using System;
namespace arrayy
{
  public class Quarto
  {
    public string Name { get; set; }
    public string Email { get; set; }

    public Quarto(string name, string email)
    {
      Name = name;
      Email = email;
    }

    public override string ToString()
    {

      return $" {Name}, {Email}";
    }

  }
}
