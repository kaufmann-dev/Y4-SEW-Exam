using System;
using System.Threading;

namespace StudentGetsHisExamAndLeaves
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new Student().Run);
            Thread t2 = new Thread(new Tresor().Run);
            Thread t3 = new Thread(new Assistent().Run);
            
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}