using System;
using System.Threading;

namespace StudentGetsHisExamAndLeaves
{
    public class Tresor
    {
        public static readonly SemaphoreSlim smt = new SemaphoreSlim(0);

        public void Run()
        {
            while (true)
            {
                smt.Wait();
                FetchExam();
                Student.sms.Release();
            }
        }

        private void FetchExam()
        {
            Thread.Sleep(500);
            Console.WriteLine("Fetched exam");
        }
    }
}