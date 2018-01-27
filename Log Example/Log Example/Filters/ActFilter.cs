
using EntityFramework;
using LogExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters
{
    public class ActFilter : FilterAttribute, IActionFilter
    {
        DatabaseContext db = new DatabaseContext();
        // Normal şartlar altında bunu buraya yazamayız.
        //Neden? Çünkü Controller ve Actionlar DbContext'e ulaşmaması gerekir. Gerçi Log tablosu için aynı bir şey yapılır.  
            
        //Action Çalıştıktan Sonra
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            db.log.Add(new Log()
            {
                UserName = "Mesut Kaya",
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Date = DateTime.Now,
                ActionName = filterContext.ActionDescriptor.ActionName,
                Information = "OnActionExecuted"
            });
            db.SaveChanges();
        }
        //Action Çalışmadan Önce
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.log.Add(new Log()
            {
                UserName = "Mesut Kaya",
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Date = DateTime.Now,
                ActionName = filterContext.ActionDescriptor.ActionName,
                Information = "OnActionExecuting"
            });
            db.SaveChanges();
        }
    }
}