using DataStructure.SearchAlgorisms;
using System;

namespace DataStructure
{
    class Program
    {
        #region props.
        public BinarySearch BinarySearch { get; set; }        
        #endregion
        #region cst.
        public Program()
        {
            this.BinarySearch = new BinarySearch();
        }
        #endregion

        #region publics
        public static void Main()
        {
            //int[] array = { 2, 3, 4, 10, 40 };
            //int count = array.Length - 1;
            //var result = BinarySearch.Exist(array, 0, count, 4); 

            int[] array = { 2, 10, 10, 10, 40 };
            int count = array.Length - 1;
            var result = BinarySearch.Exist(array, 0, count, 40, false);

            Console.WriteLine(result == -1 ? "Element not present" : $"Element found at index {result}");
            Console.ReadKey();                      
        } 
        #endregion
    }
}
