using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace ClassLibrary1
{
    public static class TakeContractOwnership
    {
        public static bool CheckTakeContractOwnership(string method)
        {
            return method == "owner";
        }

        public static string ExecuteTakeContractOwenership(object[] args)
        {
            var isContractActive = Storage.Get(Storage.CurrentContext, "Active").AsString();
            if (isContractActive == "1")
            {
                return "--> Contract already active. Cannot change owner. <--";
            }
            else
            {
                Runtime.Log("--> Contract is not active");
            }

            var account = (byte[])args[0];

            Storage.Put(Storage.CurrentContext, "Owner", account);
            Storage.Put(Storage.CurrentContext, "Active", "1");

            return "--> OWNER command successful <--";
        }
    }
}
