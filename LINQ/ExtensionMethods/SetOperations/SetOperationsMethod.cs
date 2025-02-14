using Dumpify;
using LINQ.ExtensionMethods.Mock;

namespace LINQ.ExtensionMethods.SetOperations
{
    public static class SetOperationsMethod
    {
        // https://makolyte.com/set-operations-in-csharp-intersect-union-difference-and-symmetric-difference/
        public static void PrintOutput()
        {
            // Clear collections from duplicates
            MockCollections.numbers.Distinct().Dump("Distinc()");

            // Clear collections from duplicates based on condition
            MockCollections.peoples.DistinctBy(x => x.Age).Dump("DistincBy()");

            // Splice these two collections withouth duplicates 
            MockCollections.numbers.Union(MockCollections.numbers1).Dump("Union()");

            // Intersect (gemeinsam, průnik elements) of the these two collecticions
            MockCollections.numbers.Intersect(MockCollections.numbers1).Dump("Intersect()");

            // Returns collection of elements from first collection, which
            // do not appear in the second one.
            MockCollections.numbers.Except(MockCollections.numbers1).Dump("Except");
        }
    }
}
