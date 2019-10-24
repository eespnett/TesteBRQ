using System;
using System.Collections.Generic;
using System.Text;

namespace EderTeste.Data
{
  public  class LogRepository
    {

        public bool IncluirLog(Log Entity)
        {
            bool returnIncluirLog = false;

            using (EderTesteContext context = new EderTesteContext())
            {
                context.Log.Add(Entity);
                context.SaveChanges();
                returnIncluirLog = true;
            }

            return returnIncluirLog;


        }

 

    }
}
