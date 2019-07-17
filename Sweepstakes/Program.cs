using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  class Program
  {
    static void Main(string[] args)
    {
      Sweepstakes test = new Sweepstakes("Honda Sweepstakes");
      Contestant c = new Contestant("Alexander", "Wick", "alexanderwick@gmail.com");
      
      // testing creating a player with user input
      string fname = UserInterface.SetFirstName();
      string lname = UserInterface.SetLastName();
      string email = UserInterface.SetEmail();

      Contestant c2 = new Contestant(fname, lname, email);
      test.RegisterContestant(c2);
      test.RegisterContestant(c);
      Console.WriteLine(test.PickWinner());


      /*********************************************/
      Console.ReadLine();
    }
  }
}
