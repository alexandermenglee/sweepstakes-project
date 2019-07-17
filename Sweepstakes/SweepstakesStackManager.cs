using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public class SweepstakesStackManager : ISweepstakesManager
  {
    // Member variables
    Stack<Sweepstakes> sweepstakesStack;

    // Constructor
    public SweepstakesStackManager()
    {
      sweepstakesStack = new Stack<Sweepstakes>();
    }

    // Member methods
    public void InsertSweepstakes(Sweepstakes sweepstakes)
    {
      sweepstakesStack.Push(sweepstakes);
    }

    public Sweepstakes GetSweepstakes()
    {
      return sweepstakesStack.Pop();
    }
  }
}
