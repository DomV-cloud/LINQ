using LINQ.ExtensionMethods.Mock.Peoples;

namespace LINQ.ExtensionMethods.Mock
{
    public static class MockCollections
    {
        public static IEnumerable<int> numbers = [1, 2, 3, 4, 5, 6];
        public static IEnumerable<int> numbers1 = Enumerable.Range(6, 7);
        public static IEnumerable<string> characters = ["a", "b", "c", "d", "e", "f"];
        public static IEnumerable<object> numbersAndObjects = [1, 2, "asda", 4, 5, "sdsfd"];
        public static IEnumerable<List<int>> listsOfNumbers = [[1, 2, 3, 4, 5, 6], [7, -2, -3, 4, 8]];
        public static List<People> peoples = [
            new("John", 18),
            new("Denisa", 26),
            new("Robert", 15),
            new("Jessica", 18),
        ];

    }
}
