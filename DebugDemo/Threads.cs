namespace DebugExample
{
    internal class Threads
    {
        public void RunThreads()
        {
            var thread1 = new Thread(DoAny);
            var thread2 = new Thread(DoAny);
            var thread3 = new Thread(DoAny);

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        public void DoAny()
        {
            while (true)
                for (int i = 0; i < 1000; i++)
                {
                    int p = i - 1;
                    Thread.Sleep(100);
                    int c = i + 1;
                }
        }
    }
}
