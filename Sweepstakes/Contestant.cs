using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
  public class Contestant
  {
    // Memeber variables
    private string firstName;
    private string lastName;
    private string email;
    private int registrationNumber;

    public int RegistrationNumber
    {
      get => registrationNumber;
      set => registrationNumber = value;
    }

    public string FirstName
    {
      get => firstName;
      set => firstName = value;
    }

    public string LastName
    {
      get => lastName;
      set => lastName = value;
    }

    public string Email
    {
      set => email = value;
    }

    // Constructor
    public Contestant(string firstName, string lastName, string email)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.email = email;
    }
  }
}
