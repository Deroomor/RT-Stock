using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RT.UI.Controllers
{
    public class ShareHoldingController : Controller
    {
       public  IBll.IShareHolding BllShareHolding { set; get; }
        // GET: ShareHolding
        public ActionResult Index()
        {
            var lst= this.BllShareHolding.GetEntity(x=>x);

            var rr= this.BllShareHolding.EditById(x => new { x.Name, x.Remark }, true, lst.First(), lst.Last());

            this.ViewData["lstShareHolding"] = lst;
            return View();
        }
    }
}