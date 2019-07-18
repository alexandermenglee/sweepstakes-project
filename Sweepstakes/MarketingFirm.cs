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
    public MarketingFirm(ISweepstakesManager managementSystem)
    {
      this.managementSystem = managementSystem;
    }

  }
}
