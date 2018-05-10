using Neo.SmartContract.Framework;

namespace Return42SmartContract
{
    public class Contract : SmartContract
    {
        public static int Main()
        {
            return 42; // Direct return an integer without usage of local variable
        }
    }
}
