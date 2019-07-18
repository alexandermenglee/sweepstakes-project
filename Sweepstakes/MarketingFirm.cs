using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public class MarketingFirm
  {
    // Member variables
    public ISweepstakesManager managementSystem;

    // Constructor
    public MarketingFirm()
    {
      managementSystem = DecideManagementSystem(UserInterface.ChooseListType());
    }

    public ISweepstakesManager DecideManagementSystem(string managementSystemChoice)
    {
      if (managementSystemChoice == "1")
      {
        return new SweepstakesStackManager();
      }
      else return new SweepstakesQueueManager();
    }
  }
}
