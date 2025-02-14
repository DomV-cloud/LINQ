using Dumpify;
using LINQ.ExtensionMethods.Mock;

namespace LINQ.ExtensionMethods.Projection
{
    public static class ProjectioningMethods
    {
        public static void PrintOutput()
        {
            // Select() selects every each element and than in lambda a specify what should happened with the selected element
            MockCollections.numbers.Select(x => x.ToString()).Dump("Select()");

            MockCollections.numbers.Select(x => x).Where(x => x % 2 == 0).Dump("Example Select()");

            // SelectMany() is basically works as Select(), but it flashes collection together
            // Used for nested collection in collecions
            MockCollections.listsOfNumbers.SelectMany(x => x.Select(x => x.ToString())).Dump("SelectMany()");

            // Cast() just casts to object specified in generics
            MockCollections.numbersAndObjects.Cast<int>().Dump("Cast()");

            // Chunk() split the collection into two collection (length/size is based on the input of the method)
            // e.g. here size/length for the collection should be 3
            // if the collection has size/lenght odd. It will split it up too, but not equally.
            // e.g. numbers has size/length 5 => returns two collecion. One with size/lenght 3
            // and the second one with size/length of 2
            MockCollections.numbers.Chunk(3).Dump("Chunk()");
        }
    }
}
