using Dumpify;
using LINQ.ExtensionMethods.Mock;

namespace LINQ.ExtensionMethods.ExistencyQualityCheck
{
    public static class ExistencyQualityCheckMethods
    {
        public static void PrintOutput()
        {
            // Normally, to iterate returned collection in LINQ I have to do it manually
            //  Any() method iterates, until condition is met. Then it won't continue. And it returns true or false
            MockCollections.numbers.Any(x => x > 2).Dump("Any()");

            // All() is similiar to Any(), it iterates collection as well,
            //  but it returns false/true if all elements met the condition
            MockCollections.numbers.All(x => x > 3).Dump("All()");

            // Contains() method checks, if element (specified as input parameter in the method)
            // does exists in the collection
            MockCollections.numbers.Contains(1).Dump("Contains()");
        }
    }
}
