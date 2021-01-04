using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LGUPlus.Common;


namespace HomePageWebApplication.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 메인 페이지 호출 액션 메소드
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //사용자 정보관리 서비스를 이용해 특정 사용자 정보를 조회해온다.
            UserService service = new UserService();
            var user = service.GetUserData("eddy");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}