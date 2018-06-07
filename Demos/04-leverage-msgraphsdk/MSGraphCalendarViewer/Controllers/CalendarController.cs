using MSGraphCalendarViewer.Helpers;
using MSGraphCalendarViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MSGraphCalendarViewer.Controllers
{
  [Authorize]
  public class CalendarController : Controller
  {
    public async Task<ActionResult> Index()
    {
      GraphService graphService = new GraphService();
      string accessToken = await SampleAuthProvider.Instance.GetUserAccessTokenAsync();

      ViewBag.Events = await graphService.GetCalendarEvents(accessToken);

      return View();
    }
  }
}