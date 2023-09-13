// See https://aka.ms/new-console-template for more information
using System;

namespace drewsfuckinstringconfigtask
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("How many numbers in the list?: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[length];
            Console.Write("Please input each number of the list: ");
            //populate list with the input
            for (int i = 0; i < length; i++)
            {
                list[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            int[] answer = listProduct(list);

            for(int i = 0; i < answer.Length; i++)
            {
                Console.Write(answer[i] + " ");
            }
        }
        public static int[] listProduct(int[] list)
        {
            int[] productList = new int[list.Length];
            int holder = 1;
            int counter = 0;
            //ok how im gonna do this
            //loop through and multiply them all together then divide by the index of the one youre doing. it works
            //place the product into the holder then into the product list then wipe the holder
            while (counter != list.Length) //until list is finished
            {
                for (int i = 0; i < list.Length; i++) //loop through the list
                {
                    holder = holder*list[i];  //fill holder with the product of every element             
                }
                productList[counter] = holder/list[counter]; //populate the productList with the product of every element divided by the current index into the current index
                holder = 1; //reset holder var
                counter++; //go to the next index
            }
            return productList;
        }
        /*
        Create a list of n integers where the index of the list is equal to the product of every other element in the original list
        Input: [1, 2, 3, 4]
        Output: [24, 12, 8, 6]
        Can be done easily in On^2
        Show me ancient technology and do it in On^1
        Earn your apex time
        Solve my riddle feeble mortal boy
        Extra example;
        Input: [2, 3, 4, 5]
        Output: [60, 40, 30, 24]
        */
    }
}
