using MVCCourse210710.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCourse210710.ActionFilters
{
    public class 產生ViewBag點InstructorID並設定SelectList給ViewAttribute : ActionFilterAttribute
    {
        PersonRepository repo = RepositoryHelper.GetPersonRepository();

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.Result is ViewResultBase)
            {
                //filterContext.Controller.ViewBag.InstructorID 
                //    = new SelectList(repo.GetPersonForSelectList(), "Value", "Text");

                filterContext.Controller.ViewBag.InstructorID
                    = new SelectList(repo.All(), "ID", "DisplayName");
            }

            base.OnResultExecuting(filterContext);
        }
    }
}