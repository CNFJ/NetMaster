using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetMaster.MVC.Controllers
{
    public class AssemblyController : Controller
    {
        /// <summary>
        /// 图片滚动组件
        /// </summary>
        /// <returns></returns>
        public IActionResult PicRoll()
        {
            return View();
        }
    }
}
