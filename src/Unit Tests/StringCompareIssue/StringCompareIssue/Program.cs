using System;
using System.Globalization;

namespace StringCompareIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            //thomas.lefever@telenet.be
            //https://haacked.com/archive/2012/07/05/turkish-i-problem-and-why-you-should-care.aspx/


            Console.WriteLine("Turkish I");

            string lowerDotted = "i";
            string lowerDotless = "ı";
            string normalUpper = "I";
            // string normalUpper = "I";​

            SetCulture("en-US");

            Console.WriteLine(lowerDotted.ToUpper() == normalUpper); // this gives true

            Console.WriteLine(lowerDotless.ToUpper() == normalUpper); // this gives true

            Console.WriteLine(lowerDotted.ToUpper(CultureInfo.CurrentCulture) == normalUpper); // this gives true

            Console.WriteLine(lowerDotless.ToUpper(CultureInfo.CurrentCulture) == normalUpper); // this gives false

            SetCulture("tr-TK");

            Console.WriteLine(lowerDotted.ToUpper() == normalUpper); // this gives false

            Console.WriteLine(lowerDotless.ToUpper() == normalUpper); // this gives true

            Console.WriteLine(lowerDotted.ToUpper(CultureInfo.CurrentCulture) == normalUpper); // this gives true

            Console.WriteLine(lowerDotless.ToUpper(CultureInfo.CurrentCulture) == normalUpper); // this gives false​

            Console.ReadLine();

        }

        private static void SetCulture(string culture)

        {
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);
            Console.WriteLine(culture);
        }
    }
}
