using System;

class AutoPolicy
{
    public int AccountNumber { get; set; } // policy account number
    public string MakeAndModel { get; set; } // car that policy applies to
    public string State { get; set; } // two-letter state abbreviation

    public AutoPolicy(int accountNumber, string makeAndModel, string state)
    {
        AccountNumber = accountNumber;
        MakeAndModel = makeAndModel;
        State = state;
    }
    public bool IsNoFaultState
    {
        get
        {
            bool noFaultState;
            
            switch (State)
            {
                case "MA": case "NJ": case "NY": case "PA":
                    noFaultState = true;
                    break;
                default:
                    noFaultState = false;
                    break;
            }
            return noFaultState;
        }
    }
}