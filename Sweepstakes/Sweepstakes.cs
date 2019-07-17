using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public class Sweepstakes
  {
    // Member variables
    private string name;
    int registrationNum;
    public Dictionary<int, Contestant> contestants; 

    // Constructor
    public Sweepstakes(string name)
    {
      this.name = name;
      contestants = new Dictionary<int, Contestant>();
      registrationNum = 0;
    }

    public void RegisterContestant(Contestant contestant)
    {
      // Set the contestant's registration number
      contestant.RegistrationNumber = registrationNum;

      // Add contestant to dictionary
      contestants.Add(contestant.RegistrationNumber, contestant);

      registrationNum++;
    }

    public string PickWinner()
    {
      string winner;
      int winningRegistrationNumber;

      // implement Random object
      Random rng = new Random();
      
      // produce a random number less than or equal to the number of values in the contestants dictionary
      winningRegistrationNumber = rng.Next(contestants.Count);
      winner = $"{contestants[winningRegistrationNumber].RegistrationNumber}: {contestants[winningRegistrationNumber].FirstName} {contestants[winningRegistrationNumber].LastName}";
      Console.WriteLine($"\nRandom Number: {winningRegistrationNumber}");
      return winner;
    }

    public void PrintContesantInfo(Contestant contestant)
    {
      UserInterface.DisplayContestantInformation(contestant);
    }
  }
}
