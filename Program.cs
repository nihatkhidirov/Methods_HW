namespace Methods_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForMethods
            //Console.WriteLine(Division(100, 200));
            //int[] nums = { 100, 200, 300, 12, 321 };
            //int result = Sum(nums);
            //Console.WriteLine("Ededlerin cemi:" + result);
            //FindSimpleOrComplex(16);
            //IsPower(32);
            #endregion
           
        }
        #region Method_Task_1
        //Bir method olsun iki parametr qəbul etsin və bu parametrlərdən birincini ikinciyə bölüb nəticəni geri qaytarsın.


        //static double Division(double a, double b)
        //{
        //    double division = a / b;
        //    return division;
        //}
        #endregion
        #region Method_Task_2
        //Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.

        //static int Sum(params int[] nums)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum = sum + nums[i];
        //    }
        //    return sum;

        //}
        #endregion
        #region Task_3
        static int FindOddNumbers(int n, int m)
        {
            int count = 0;
            
            for (int i = n; i <=m; i++)
            {

                if (i % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
        #region Task_4
        static void FindSimpleOrComplex(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
                Console.WriteLine(number + ":" + "Murekkebdir");
            else
            {
                Console.WriteLine(number + ":" + "Sadedir");
            }
        }
        #endregion
        #region Task_5
        static void IsPower(double number)
        {
         
            while (number > 0)
            {

                number = number / 2;
                if (number == 1)
                {
                    Console.WriteLine("quvvetidir");
                    break;
                }
                else if (number % 2 == 1)
                {
                    Console.WriteLine("quvveti deyil");
                    break;
                }


            }
        }
        #endregion

    }

}