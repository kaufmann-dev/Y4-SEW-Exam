using System;
using System.Threading;

namespace StudentGetsHisExamAndLeaves
{
    public class Assistent
    {
        public static readonly SemaphoreSlim sma = new SemaphoreSlim(0);

        public void Run()
        {
            while (true)
            {
                sma.Wait();
                Check();
                Student.sms.Release();
            }
        }

        private void Check()
        {
            Thread.Sleep(10);
            Console.WriteLine("Assistent checked exam");
        }
    }
}