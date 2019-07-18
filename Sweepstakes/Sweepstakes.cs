using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public class Sweepstakes : ISubject
  {
    // Member variables
    private string name;
    int registrationNum;
    public Dictionary<int, Contestant> contestants;
    // Member variable to hold winner
    private Contestant winningContestant;
    public List<IObserver> NotifiedContestants;

    public Contestant WinningContestant
    {
      get => winningContestant;
      set
      {
        winningContestant = value;
        Notify();
      }
    }

    // Constructor
    public Sweepstakes(string name)
    {
      this.name = name;
      contestants = new Dictionary<int, Contestant>();
      registrationNum = 0;
      NotifiedContestants = new List<IObserver>();
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
      WinningContestant = contestants[winningRegistrationNumber];
      return winner;
    }

    public void PrintContesantInfo(Contestant contestant)
    {
      UserInterface.DisplayContestantInformation(contestant);
    }

    // Implementing ISubject interface
    public void Register(IObserver observer)
    {
      NotifiedContestants.Add(observer);
    }
    public void Unregister(IObserver observer)
    {
      NotifiedContestants.Remove(observer);
    }

    public void Notify()
    {
      foreach(Contestant contestant in NotifiedContestants)
      {
        contestant.Update(this);
      }
    }

  }
}

