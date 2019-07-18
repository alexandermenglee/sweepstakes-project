using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public class SweepstakesQueueManager : ISweepstakesManager
  {
    // Member variables
    Queue<Sweepstakes> sweepstakesQueue;

    // Constructor
    public SweepstakesQueueManager()
    {
      sweepstakesQueue = new Queue<Sweepstakes>();
    }
  
    // Member methods
   public void InsertSweepstakes(Sweepstakes sweepstakes)
    {
      sweepstakesQueue.Enqueue(sweepstakes);
    }

    public Sweepstakes GetSweepstakes()
    {
      return sweepstakesQueue.Dequeue();
    }
  }
}
