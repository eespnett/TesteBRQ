using System;
using System.Collections.Generic;
using System.Text;
using EderTeste.Data;
using EderTeste.Entity;



namespace EderTeste.Business
{
  public  class LogBusiness
    {
        public bool IncluirLog(LogEntity entity)
        {
            bool returnIncluirLog = false;

            try
            {
                Log obj = new Log() {dtLog=entity.dtLog,
                idLog= entity.idLog,
                idOperacao=entity.idOperacao,
                JsaonObject=entity.JsaonObject,
                Log=entity.Log};

                returnIncluirLog = new LogRepository().IncluirLog(obj);


            }
            catch (Exception ex)
            {
                returnIncluirLog = false;

                throw ex;
            }

            return returnIncluirLog;

        }


    }
}
