using Dumpify;
using LINQ.ExtensionMethods.Mock;

namespace LINQ.ExtensionMethods.Partitioning
{
    public static class PartitioningMethods
    {
        public static void PrintOutput()
        {
            // Skip() method skips number of elemnts (specified as input of the method) in the collection
            MockCollections.numbers.Skip(3).Dump("Skip()");

            // Take() take number of elements (specified as input in the method) in the collection
            MockCollections.numbers.Take(3).Dump("Take()");

            // SkipWhile() iterates and skips elements in the collection until the condition is met
            MockCollections.numbers.SkipWhile(x => x < 3).Dump("SkipWhile()");

            // TakeWhile() iterates and takes elements in the collection until the condition is met
            MockCollections.numbers.TakeWhile(x => x < 3).Dump("TakeWhile()");
        }
    }
}
