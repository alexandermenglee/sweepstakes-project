using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public static class UserInterface
  {
    static UserInterface()
    {

    }
    
    public static string SetFirstName()
    {
      string firstName;

      Console.WriteLine("First Name: ");
      firstName = Console.ReadLine();
      firstName.ToLower().Trim();

      return firstName;
    }

    public static string SetLastName()
    {
      string lastName;

      Console.WriteLine("Last Name: ");
      lastName = Console.ReadLine();
      lastName.ToLower().Trim();

      return lastName;
    }

    public static string SetEmail()
    {
      string email;

      Console.WriteLine("Email: ");
      email = Console.ReadLine();
      email.ToLower().Trim();

      if (!email.Contains("@"))
      {
        Console.WriteLine("\nPlease enter in a valid email address");
        SetEmail();
      }

      return email;
    }

    public static int SetRegistrationNumber()
    {
      string registrationNumber;


      Console.WriteLine("\nManually set a contestants registration number: ");
      registrationNumber = Console.ReadLine();

      try
      {
        return int.Parse(registrationNumber);
      }
      catch(Exception e)
      {
        Console.WriteLine("\nEnter in numbers only");
        return SetRegistrationNumber();
      }
    }
  }
}
