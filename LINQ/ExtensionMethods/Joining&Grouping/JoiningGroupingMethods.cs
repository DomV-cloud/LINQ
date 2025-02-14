using Dumpify;
using LINQ.ExtensionMethods.Mock;

namespace LINQ.ExtensionMethods.Joining_Grouping
{
    public static class JoiningGroupingMethods
    {
        public static void PrintOutput()
        {
            // It creates Tuple from two collections
            // z.B. (numbers[0], characters[0]), (numbers[1], characters[1] ... etc)
            MockCollections.numbers.Zip(MockCollections.characters).Dump();
        }
    }
}
