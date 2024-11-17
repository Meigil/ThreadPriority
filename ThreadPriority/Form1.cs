
using System;
using System.Threading;
using Timers = System.Timers;
using System.Threading.Tasks;


namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();

        }

        private void frmTrackThread_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            lblThread.Text = "-Thread Starts-";
            ThreadStart thread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart thread2 = new ThreadStart(MyThreadClass.Thread2);
            Thread ThreadA = new Thread(thread1);
            Thread ThreadB = new Thread(thread1);
            Thread ThreadC = new Thread(thread2);
            Thread ThreadD = new Thread(thread2);

            ThreadA.Name = "Thread A Process ";
            ThreadB.Name = "Thread B Process ";
            ThreadC.Name = "Thread C Process ";
            ThreadD.Name = "Thread D Process ";

            ThreadA.Priority = System.Threading.ThreadPriority.Highest;
            ThreadB.Priority = System.Threading.ThreadPriority.Normal;
            ThreadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            ThreadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Console.WriteLine("-End of Thread");
            lblThread.Text = "- End of Thread";

        }
    }
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int t1 = 0; t1 <= 2; t1++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + t1);
                Thread.Sleep(500);

            }
        }
        public static void Thread2()
        {
            for (int t2 = 0; t2 <= 2; t2++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + t2);
                Thread.Sleep(1500);

            }
        }


    }
    
    

}
