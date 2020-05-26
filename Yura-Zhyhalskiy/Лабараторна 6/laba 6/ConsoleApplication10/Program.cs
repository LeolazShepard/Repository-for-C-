using System;
using System.Threading;
using System.Threading.Tasks;
namespace listing_8
{
    class DemoCancelTask
    {
        static void MyTask(Object ct)
        {
            CancellationToken cancelTok = (CancellationToken)ct;
            cancelTok.ThrowIfCancellationRequested();
            Console.WriteLine("MyTask() starting");
            for (int count = 0; count < 10; count++)
            {
                if (cancelTok.IsCancellationRequested)
                {
                    Console.WriteLine("Cancellation request" + "received.");
                    cancelTok.ThrowIfCancellationRequested();
                }
                Thread.Sleep(500);
                Console.WriteLine("In MyTask(), count is " + count);
            }
            Console.WriteLine("MyTask terminating");
        }
        static void Main(){
 Console.WriteLine("Main thread starting.");
 CancellationTokenSource cancelTokSrc=new
CancellationTokenSource();
 Task tsk = Task.Factory.
 StartNew(MyTask, cancelTokSrc.Token, cancelTokSrc.Token);
 Thread.Sleep(2000);
 try{
 cancelTokSrc.Cancel();
 tsk.Wait();} 
 catch (AggregateException exc) {
 if (tsk.IsCanceled)
 Console.WriteLine("\ntsk Cancelled\n");}
 finally{
 tsk.Dispose();
 cancelTokSrc.Dispose();}
 Console.WriteLine("Main thread ending.");
 Console.ReadKey();}}
    }
