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
    
    public static void StartingMessage()
    {
      Console.WriteLine("\nPlease add user information:");
    }
    public static string SetFirstName()
    {
      string firstName;

      Console.WriteLine("\nFirst Name: ");
      firstName = Console.ReadLine().ToLower().Trim();

      return firstName;
    }

    public static string SetLastName()
    {
      string lastName;

      Console.WriteLine("\nLast Name: ");
      lastName = Console.ReadLine().ToLower().Trim();

      return lastName;
    }

    public static string SetEmail()
    {
      string email;

      Console.WriteLine("Email: ");
      email = Console.ReadLine().Trim();

      if (email.Contains("@") && email.Contains("."))
      {
        return email;
      }

      Console.WriteLine("\nPlease enter in a valid email address");
      return SetEmail();
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

    public static void DisplayContestantInformation(Contestant contestant)
    {
      Console.WriteLine($"\nRegistration ID: {contestant.RegistrationNumber} Contestant Name: {contestant.FirstName} {contestant.LastName}");
    }

    public static string NameSweepstakes()
    {
      Console.WriteLine("\nName of sweepstakes: ");
      return Console.ReadLine().Trim();
    }

    public static string ChooseListType()
    {
      string listType;

      Console.WriteLine("\nWhat type of management system would you like to use? Enter in the corresponding number: \n1: Stack (LIFO - Last-in, First out) \n2: Queue (FIFO - First-in, First out)");
      listType = Console.ReadLine().Trim();

      if(listType == "1" || listType == "2")
      {
        return listType;
      }

      Console.WriteLine("Please enter in either 1 or 2");
      return ChooseListType();
    }
  }
}
