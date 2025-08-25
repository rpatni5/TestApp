using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestApp.Models.View_Models;
using TestApp.Services.Services;

namespace TestApp.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        private readonly PowerBIService _powerBIService = new PowerBIService();

        // Replace these with your report/workspace IDs
        private readonly string workspaceId = "585abcd1-f862-4212-9ee5-98e7d031ba48";
        private readonly string reportId = "ba4144cbb0542c7a1a4a";

        public async Task<ActionResult> Index()
        {
            //string accessToken = await _powerBIService.GetAccessTokenAsync();
            //var report = await _powerBIService.GetReportAsync(workspaceId, reportId, accessToken);

            var model = new EmbedReport
            {
                //AccessToken = accessToken,
                //EmbedUrl = report["embedUrl"].ToString(),
                //ReportId = report["id"].ToString()
            };

            return View(model);
        }
    }
}
