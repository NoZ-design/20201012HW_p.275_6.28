using System;
using System.Collections.Generic;
using System.Text;

namespace _20201012HW_p._275_6._28
{
    class AutoPolicy
    {
        public int AccountNumber { get; set; }
        public string MakeAndModel { get; set; }
        public string state;


        public AutoPolicy (int accountNumber,string makeAndModel,string state)
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
                    case "MA": case "CT": case "ME": case "NH": case "NJ": case "NY": case "PA": case "VT":
                        noFaultState = true;
                        break;
                    default:
                        noFaultState = false;
                        break;
                }
                return noFaultState;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                if (value == "MA" || value == "CT" || value == "ME" || value == "NH" || value == "NJ" || value == "NY" || value == "PA" || value == "VT")
                {
                    state = value;
                }
                else
                {
                    state = "error";
                }
            }
        }
    }
}
