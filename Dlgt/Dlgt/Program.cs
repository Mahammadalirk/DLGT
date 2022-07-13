using System;

namespace Dlgt
{
    class Program
    {
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str);

        ////public delegate int StringLength(string str, int a);

        //public delegate string StringLength1(string str,int a);



        static void Main(string[] args)
        {
            #region Predicate,Action
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(Sum(CheckOdd,arr));
            //Console.WriteLine(Sum(CheckEven, arr));
            //Console.WriteLine(Sum(CheckMoreThanFive, arr));

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result1 = numbers.FindAll(m => m > 5 && m < 9); //Anonimdir(bir defe istifade olunur)

            ////var result2 = numbers.FindAll(CheckMoreThanFive);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            //Test(StringToUpper, "HuseyN");
            //Test(StringToLower, "HuseyN");


            //String str = new String("EmiL");



            //ChangeString change = StringToLower;
            //change += StringToUpper;
            //change += delegate (string s)
            //{
            //    Console.WriteLine(s.ToUpper());
            //};
            //change.Invoke("HuseyN");
            //change += s => Console.WriteLine(s.ToUpper());
            //change("HuseyN");

            //Action<string,int,string> action = StringToLower;
            //action += StringToUpper;
            //action += delegate (string a, int b, string c)
            //{
            //    Console.WriteLine(a.ToUpper() + " Age:" + "--" + b + " " + c);
            //};
            //action("HuseyN",23,"P130");
            #endregion

            ////Console.WriteLine(Test(StrLength, "HuseyN", 5));
            //Console.WriteLine(Test1(StrLength1, "HuseyN", 5));  //ToString

            Func<string, int, string> func = StrLength1;
            Func<string, int, int> func2 = StrLength2;
            Console.WriteLine(func("Huseyn", 23));

        }



        //function
        ////public static int StrLength(string str, int m)
        //{
        //    return str.Length + m;
        //}
        ////public static int Test(StringLength func, string str, int m)
        //{
        //    return func(str, m);
        //}
        public static string StrLength1(string str, int a)
        {
            return str.ToString() + "-" + a;
        }

        //public static string Test1(StringLength1 func, string str, int a)
        //{
        //    return func(str, a);
        //}

        public static int StrLength2(string str, int a)
        {
            return str.Length + a;
        }



        //action
        public static void StringToUpper(string str, int age, string className)
        {
            Console.WriteLine(str.ToUpper() + " Age:" + " " + age + " " + className);
        }

        public static void StringToLower(string str, int age, string className)
        {
            Console.WriteLine(str.ToLower() + " Age:" + " " + age + " " + className);
        }

        //public static void Test(ChangeString func,string str)
        //{
        //    func(str);
        //}
        //Preciate
        public static bool CheckOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool CheckMoreThanFive(int number)
        {
            return number > 5;
        }

        public static int Sum(Predicate<int> predicate, int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }

            return sum;

        }

        //public static int SumEven(CheckNums func,int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;

        //}

        //public static int SumMoreThanFive(int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;

        //}
    }
}
