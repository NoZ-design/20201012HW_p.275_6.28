using System;

namespace _20201012HW_p._275_6._28
{
    class AutoPolicyTest
    {
        static void Main(string[] args)
        {
            AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota", "NJ");
            AutoPolicy policy2 = new AutoPolicy(22222222, "Ford", "MM");

            PolicyInNoFaultState(policy1);
            PolicyInNoFaultState(policy2);
        }

        public static void PolicyInNoFaultState(AutoPolicy policy)
        {
            Console.WriteLine("The auto policy:");
            Console.Write($"Account#:{policy.AccountNumber};");
            Console.WriteLine($"Car:{policy.MakeAndModel};");
            Console.Write($"State{policy.State};");
            Console.Write($"({(policy.IsNoFaultState ? "is":" is not ")})");
            Console.WriteLine("a no-fault state\n");
        }
    }
}
