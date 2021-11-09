using System;
using System.Threading;

namespace StudentGetsHisExamAndLeaves
{
    public class Student
    {
        public static readonly SemaphoreSlim sms = new SemaphoreSlim(0);

        public void Run()
        {
            while (true)
            {
                Tresor.smt.Release();
                sms.Wait();
                GetExam();
                Assistent.sma.Release();
                sms.Wait();
                Leave();
            }
        }

        private void GetExam()
        {
            Thread.Sleep(100);
            Console.WriteLine("Got exam");
        }
        
        private void Leave()
        {
            Thread.Sleep(100);
            Console.WriteLine("Student left university");
        }
    }
}