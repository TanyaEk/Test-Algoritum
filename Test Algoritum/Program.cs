namespace Test_Algoritum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Algoritum
            //задача 1
            //timely algoritum

            //first
            /*int[] arr = new int[1000];
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = i * 2;
            }*/
            // i think the timely is O(n)

            //second
            /*int count = 0;
            for (int i = 0; i < 1000; i++) 
            {
                for (int j = 0; j < 1000; j++)
                {
                    count++;
                }
            }*/
            //i think the timely is O(1)

            //third
            /*int[] arr = { 10, 20, 30, 40 };
            int x = arr[2] + arr[3];
            Console.WriteLine(x);*/
            //i think the timely is O(1)



            //задача 2
            //The line of the smallest number
            //the entry thingy: int[] arr = { 4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7}
            //dealing with it


            //the entry
            int[] arr = { 4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7 };

            //probably the void here
            BubbleSort(arr);

            //like the stats or things
            int min = 0;
            int count = 1;
            int TheMaxlength = 1;
            int start = min;

            //the whole algoritum thing
            for (int i = 1; i < arr.Length; i++) 
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    count++;
                    if (count > TheMaxlength)
                    {
                        TheMaxlength = count;
                        start = arr[i - count + 1];
                    }
                }
                else 
                {
                    count = 1;
                }
            }

            //The whole thing exit
            Console.WriteLine("Подреден масив: " + string.Join(" ", arr));
            Console.WriteLine("Най-дълга поредица от най-малкото: ");
            for (int i = 0; i < TheMaxlength; i++) 
            {
                Console.Write((start + i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Дължина: " + TheMaxlength);

            //the void BubbleSort on the test
            static void BubbleSort(int[] array) 
            {
                //the number sorts
                int n = array.Length;
                bool swapped;

                do
                {
                    swapped = false;
                    for (int i = 1; i < n; i++) 
                    {
                        if (array[i - 1] > array[i])
                        {
                            int temp = array[i - 1];
                            array[i - 1] = array[i];
                            array[i] = temp;
                            swapped = true;
                        }
                    }
                    n--;
                } while (swapped);
            }
        }
    }
}
