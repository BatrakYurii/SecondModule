using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    public static class Starter
    {
        public static void Run()
        {
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                var typeOfLog = random.Next(0, 3);
                switch (typeOfLog)
                {
                    case 0:
                        Action.Information();
                        break;
                    case 1:
                        Action.Warning();
                        break;
                    case 2:
                        Action.Error();
                        break;
                }
            }
            var allLogs = Logger.Intance.GetAllLogs();
            File.WriteAllText("log.txt", allLogs);
        }
    }
}
