using Dumpify;
using LINQ.ExtensionMethods.Mock;

namespace LINQ.ExtensionMethods.Filtering
{
    public static class FilteringMethods
    {
        public static void PrintOutput()
        {
            MockCollections.numbers.Where(x => x > 2).Dump("Where()");

            // Dump is used for better and prettier format in console
            MockCollections.numbersAndObjects.OfType<string>().Dump("OfType()");
            //OfType gives the values specified in generics. In this case "string".
        }
    }
}
