using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class ApplicationManager
    {
        public void MakeanApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            
            creditManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
       
        public void MakeCreditPreNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
           
        }

      
    }
    }

