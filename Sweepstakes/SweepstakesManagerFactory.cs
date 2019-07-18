using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public static class SweepstakesManagerFactory
  {

    public static ISweepstakesManager CreateManagementSystem(string choice)
    {
      ISweepstakesManager sweepstakesManager;

      sweepstakesManager = null;

      switch (choice)
      {
        case "1":
          sweepstakesManager = new SweepstakesStackManager();
          break;

        case "2":
          sweepstakesManager = new SweepstakesQueueManager();
          break;

        default:
          Console.WriteLine("Invalid input.");
          break;
      }

      return sweepstakesManager;
    }
  }
}
