namespace cs_con_Arrays
{
    class Demo 
    {
        public int ID;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of Value Types (Single Dimensional - Array of Rank 1)
            int[] arr;          // Declaration
            arr = new int[5];   // Instantiation
            arr[0] = 10;        // Initialization
            arr[1] = 11;
            arr[2] = 12;
            arr[3] = 13;
            arr[4] = 14;
            Console.WriteLine("Elements in arr");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]}");            // Console.Write( " {0}", arr[i] );
            }
            Console.WriteLine();
            Console.WriteLine();


            int[] arr2 = new int[5];        // Declaration, Instantiate, Initialize (implicit - DEFAULT value)
            arr2[3] = 50;                   // changing the value of the fourth element
            Console.WriteLine("Elements in arr2");
            foreach (int i in arr2)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] arr3 = new int[5] { 10, 11, 12, 13, 14 };   // Declaration, Instantiate, Initialize (explicit)
            Console.WriteLine("Elements in arr3");
            foreach (int i in arr3)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine();


            int[] arr4 = { 40, 10, 50, 20, 30 };            // size is inferred because of initialization values
            Console.WriteLine("Elements in arr4 (unsorted data)");
            foreach (int i in arr4)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();

            Array.Sort(arr4);
            Console.WriteLine("Elements in arr4 (after sorting inplace)");
            foreach (int i in arr4)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine();


            // Array of Reference Type

            Demo[] objArr = new Demo[3];    // Declaration, Instantiate, Initialize (implicit to NULL-default)
            objArr[0] = new Demo();     // initialize each element Explicitly.
            objArr[0].ID = 10;
            objArr[1] = new Demo();     // initialize each element Explicitly.
            objArr[1].ID = 20;
            objArr[2] = new Demo();     // initialize each element Explicitly.
            objArr[2].ID = 30;
            Console.WriteLine("Elements in Array of Objects");
            foreach (Demo obj in objArr)
            {
                Console.WriteLine($"ID = {obj.ID}");
            }

            // objArr[4] = new Demo();      // RUNTIME ERROR: Array size is fixed
            Console.WriteLine("Number of elements in the Array: {0}", objArr.Length);
            Console.WriteLine();
            Console.WriteLine();


            // Array of Rank 2 (i.e., Two-Dimensional Array)
            int[,] arr2d = new int[2, 3];       // 2 rows, 3 cols
            arr2d[0, 0] = 10;
            arr2d[0, 1] = 20;
            arr2d[0, 2] = 30;
            arr2d[1, 0] = 40;
            arr2d[1, 1] = 50;
            arr2d[1, 2] = 60;

            // Another example of Array of Rank 2
            int[,] arr2db = new int[2, 3] { { 10, 20, 30},
                                            { 40, 50, 60 } };
            int rows = arr2db.GetLength(0);                     // 2 (Rank #1)
            int cols = arr2db.GetLength(1);                     // 3 (Rank #2)
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", arr2db[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Number of elements in Rank[0]: {0}", arr2db.GetLength(0));
            Console.WriteLine("Number of elements in Rank[1]: {0}", arr2db.GetLength(1));
            Console.WriteLine("Number of elements in the Array: {0}", arr2db.Length);
            Console.WriteLine();

            // NOTE: will not work on multi-dimensional array
            // Array.Sort(arr2db);
            // Array.IndexOf(arr2db, 10);
        }
    }
}