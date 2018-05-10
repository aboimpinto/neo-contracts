using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace ClassLibrary1
{
    public class Contract1 : SmartContract
    {
        public delegate bool CheckDelegate(string method);

        public static string Main(string method, params object[] args)
        {
            if (TakeContractOwnership.CheckTakeContractOwnership(method))
            {
                return TakeContractOwnership.ExecuteTakeContractOwenership(args);
            }

            if (SendContribution.CheckSendContribution(method))
            {
                return SendContribution.ExecuteSendContribution(args);
            }

            if (ListContributions.CheckListContributions(method))
            {
                return ListContributions.ExecuteListContributions(args);
            }

            return "ERROR 000: Unknown method " + method;
        }
    }
}
