using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextService;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTextServiceTests();

            Console.ReadKey();
        }

        static private void RunTextServiceTests()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Start of Text Service Tests");
            Console.WriteLine("*********************************");

            // Test TextService 1
            var _TextService = new TextService.TextService();
            int testNumber = 1;
            int passedTest = 0;

            string expecting = "RANDY";
            string sending = "Randy";
            int flag = 1;
            string returned = _TextService.Case(sending, flag);
            var isEqual = string.Compare(expecting, returned);
            var isEqualString = "";
            if (isEqual == 0)
            {
                isEqualString = "PASS";
                passedTest += 1;
            }
            else
                isEqualString = "FAIL";
            Console.WriteLine("TEST {0} \nSending: {1} \nExpecting: {2} \nReturned: {3} \nResults: {4}\n\n", testNumber, sending, expecting, returned, isEqualString);

            // Test TextService 2
            testNumber++;
            expecting = "randy";
            sending = "Randy";
            flag = 2;
            returned = _TextService.Case(sending, flag);
            isEqual = string.Compare(expecting, returned);
            if (isEqual == 0)
            {
                isEqualString = "PASS";
                passedTest += 1;
            }
            else
                isEqualString = "FAIL";
            Console.WriteLine("TEST {0} \nSending: {1} \nExpecting: {2} \nReturned: {3} \nResults: {4}\n\n", testNumber, sending, expecting, returned, isEqualString);

            // Test TextService 3
            testNumber++;
            expecting = "randy";
            sending = "RaNdY";
            flag = 2;
            returned = _TextService.Case(sending, flag);
            isEqual = string.Compare(expecting, returned);
            if (isEqual == 0)
            {
                isEqualString = "PASS";
                passedTest += 1;
            }
            else
                isEqualString = "FAIL";
            Console.WriteLine("TEST {0} \nSending: {1} \nExpecting: {2} \nReturned: {3} \nResults: {4}\n\n", testNumber, sending, expecting, returned, isEqualString);



            //// Test TextService Template
            //testNumber++;
            //expecting = "";
            //sending = "";
            //returned = _TextService.Case(sending, flag);
            //isEqual = string.Compare(expecting, returned);
            //if (isEqual == 0)
            //{
            //    isEqualString = "PASS";
            //    passedTest += 1;
            //}
            //else
            //    isEqualString = "FAIL";
            //Console.WriteLine("TEST {0} \nSending: {1} \nExpecting: {2} \nReturned: {3} \nResults: {4}\n\n", testNumber, sending, expecting, returned, isEqualString);


            Console.WriteLine("*********************************");
            Console.WriteLine("Test Completed: {0}, Test Passed: {1}", testNumber, passedTest);
            Console.WriteLine("End of Text Service Tests");
            Console.WriteLine("*********************************");
        }
    }
}
