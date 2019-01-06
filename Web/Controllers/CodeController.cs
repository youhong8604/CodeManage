using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CodeController : Controller
    {
        /// <summary>
        /// 代码列表界面
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            //获取收藏的代码列表
            var listCode = Services.CodeInfoService.Instance.GetAllList();

            return View(listCode);
        }

        /// <summary>
        /// 代码编辑界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {
            return View();
        }
        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Save(DomainModel.CodeInfo code)
        {
            var result = new DomainModel.JsonOut();
            try
            {
                if (code.Id > 0)
                    Services.CodeInfoService.Instance.UpdateCode(code);
                else
                    Services.CodeInfoService.Instance.AddCode(code);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return Json(result);
        }
	}
}