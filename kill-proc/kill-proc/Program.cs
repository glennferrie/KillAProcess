using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace killproc
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
                throw new ArgumentNullException("No arguments. 'processId' expected.");

            #region 1 Arg
            if (args.Length == 1)
            {
                try
                {
                    int id;
                    if (!int.TryParse(args[0], out id))
                        throw new ArgumentNullException("First Arg is not an Integer, pass a active processid (ex. 1809) ");

                    var proc = Process.GetProcessById(id);
                    proc.Kill();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex);
                    Console.ReadLine();
                }

                return;
            }
            #endregion
        }
    }
}
