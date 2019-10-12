namespace DataStructure.SearchAlgorisms
{
    public class BinarySearch
    {
        #region helpers.

        /// <summary>
        /// Returns index of x if it is present in int[], else return -1,
        /// </summary>
        /// <param name="array">array of sorted numbers</param>
        /// <param name="l">start index</param>
        /// <param name="r">end index</param>
        /// <param name="x">searched number</param>
        /// <returns>index of x</returns>
        public static int Exist(int[] array, int l, int r, int x)
        {
            while (l <= r)
            {
                int med = (l + r) / 2;
                // Check if x is present at mid
                if (x == array[med])
                    return med;
                // If x is smaller, ignore right half
                if (x < array[med])
                    r = (med - 1);
                // If x greater, ignore left half
                else
                    l = (med + 1);
            }
            return -1;
        }

        /// <summary>
        /// Returns index of first or last occurrence of a number if it is present in int[], else return -1,    
        /// </summary>
        /// <param name="array">array of sorted numbers</param>
        /// <param name="l">start index</param>
        /// <param name="r">end index</param>
        /// <param name="x">searched number</param>
        /// <param name="first">boolean: true if searching first occurrence or false if last</param>
        /// <returns>index of x</returns>
        public static int Exist(int[] array, int l, int r, int x, bool first)
        {
            int result = -1;
            while (l <= r)
            {
                int med = (l + r) / 2;
                // Check if x is present at mid
                if (x == array[med])
                {
                    result = med;
                    if (first)
                        r = (med - 1); //ignore right half
                    else
                        l = (med + 1); //ignore left half
                }
                else if (x < array[med])
                    r = (med - 1);
                else
                    l = (med + 1);
            }
            return result;
        }
        #endregion
    }
}
