namespace Methods_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForMethods
            //Console.WriteLine(Division(100, 200));
            //int[] nums = { 100, 200, 300, 12, 321 };
            //int result=Sum(nums);
            //Console.WriteLine("Ededlerin cemi:" +result) ;
            #endregion
            #region Task_3
            //Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.

            //int count = 0;
            //int n = 100;
            //int m = 200;
            //for (int i = n; i < m; i++)
            //{

            //    if (i % 2 == 1)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region Task_4
            //int number = 51;
            //int count = 0;
            //for (int i = 1; i <=number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        count++;
            //    }
            //}
            //if (count > 2)
            //    Console.WriteLine(number + ":" + "Murekkebdir");
            //else
            //{
            //    Console.WriteLine(number + ":" + "Sadedir");
            //}
            #endregion
            #region Task_5
            //Verilmiş müsbət tam n ədədinin 2 - nin qüvvəti olub-olmamasını tapın.
            Console.WriteLine("Musbet Tam Ededinizi Daxil Edin: ");
            double n = Convert.ToDouble(Console.ReadLine());
            // 2,4,8,16,32,64,128,256,512,1024,2048,4096,8192
            int count = 0;

            while (n > 0)
            {

                n = n / 2;
                if (n == 1)
                {
                    Console.WriteLine("quvvetidir");
                    break;
                }
                else if (n % 2 == 1)
                {
                    Console.WriteLine("quvveti deyil");
                    break;
                }


            }
            #endregion
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




        }
    }

}