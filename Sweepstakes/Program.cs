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
      Sweepstakes johnSweepstakes = new Sweepstakes("John's Sweepstakes");
      Contestant c1 = new Contestant("John", "Wick", "johnwick@gmail.com");
      Contestant c2 = new Contestant("Jon", "Snow", "jonsnow@gmail.com");
      Contestant c3 = new Contestant("John", "Stewart", "johnstewart@gmail.com");

      johnSweepstakes.RegisterContestant(c1);
      johnSweepstakes.RegisterContestant(c2);
      johnSweepstakes.RegisterContestant(c3);

      johnSweepstakes.Register(c1);
      johnSweepstakes.Register(c2);
      johnSweepstakes.Register(c3);

      johnSweepstakes.PickWinner();

      /************************************************************/
      Console.ReadLine();
    }
  }
}
