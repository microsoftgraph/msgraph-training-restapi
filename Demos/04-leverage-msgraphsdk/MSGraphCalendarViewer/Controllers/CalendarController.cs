using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSGraphCalendarViewer.Helpers;
using MSGraphCalendarViewer.Models;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MSGraphCalendarViewer.Controllers
{
    [Authorize]
    public class CalendarController : Controller
    {
        // GET: Calendar
        public async Task<ActionResult> Index()
        {
            GraphService graphService = new GraphService();
            string accessToken = await SampleAuthProvider.Instance.GetUserAccessTokenAsync();

            ViewBag.Events = await graphService.GetCalendarEvents(accessToken);

            return View();
        }
    }
}