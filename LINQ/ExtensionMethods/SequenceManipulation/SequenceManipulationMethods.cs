using Dumpify;
using LINQ.ExtensionMethods.Mock;

namespace LINQ.ExtensionMethods.SequenceManipulation
{
    public static class SequenceManipulationMethods
    {
        public static void PrintOutput()
        {
            // Append() methods add new element at the end of the collection
            MockCollections.numbers.Append(7).Dump("Append()");

            // Preppend() method add new element at the beginning
            MockCollections.numbers.Prepend(0).Dump("Prepend()");

        }
    }
}
