using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RadarcOnline.App.Presentation.Mvc.Models.Shared;

namespace RadarcOnline.App.Presentation.Mvc.Extensions.Controllers
{
    public abstract class BaseController : Controller
    {
        public int GetGridStartIndex(GridRequestViewModel gridRequest)
        {
            return (1 + gridRequest.RowStartIndex / gridRequest.RowCount) - 1;
        }
    }
}
