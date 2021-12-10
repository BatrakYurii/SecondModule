using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    class Action
    {
        public Action() 
        { 

        }
        public static Result Information()
        {
            Logger.Intance.Log(TypeLog.Infrmation, $"Information Method");
            return new Result { Status = true };
        }

        public static Result Warning()
        {
            Logger.Intance.Log(TypeLog.Warning, $"Warning Method");
            return new Result { Status = true };
        }

        public static Result Error()
        {
            Logger.Intance.Log(TypeLog.Error, $"Error Method");
            return new Result { Status = false, Message = $"Error occured" };
        }

    }
}
