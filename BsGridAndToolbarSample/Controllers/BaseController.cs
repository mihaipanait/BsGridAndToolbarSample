using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RequireJS;
using MyGrid.Mock;

namespace MyGrid.Controllers
{
    public class BaseController : RequireJS.RequireJsController
    {
        public BFormsContext Db
        {
            get
            {
                return BFormsContext.Get();
            }

        }

        public override void RegisterGlobalOptions()
        {
            RequireJsOptions.Add(
                "homeUrl",
                Url.Action("Index", "Home", new { area = "" }),
                RequireJsOptionsScope.Global);
        }
    }
}
