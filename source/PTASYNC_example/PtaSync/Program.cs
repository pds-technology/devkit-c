using System;
using System.Diagnostics;

namespace PtaSync
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
                Trace.Listeners.Add(new TextWriterTraceListener("Sync.log"));
                Trace.AutoFlush = true;

                var excelFilePathName = args[0];
                var eaModelFileName = args[1];

                Trace.WriteLine(String.Format("Synchronizing from '{0}' to '{1}'.", excelFilePathName, eaModelFileName));

                using (var synchronizer = new PtaModelSynchronizer(excelFilePathName, eaModelFileName))
                {
                    synchronizer.Synchronize();
                }

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                Trace.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
