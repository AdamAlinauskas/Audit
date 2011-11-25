using System.Web.Mvc;
using Dto;
using Service;

namespace UI.Controllers
{
    public class AuditTemplateController : Controller
    {
        private readonly ICreateAuditTemplateCommand createAuditTemplate;

        public AuditTemplateController(ICreateAuditTemplateCommand createAuditTemplate)
        {
            this.createAuditTemplate = createAuditTemplate;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Create(AuditTemplateDto auditTemplateDto)
        {
            createAuditTemplate.Execute();
            return RedirectToAction("Index");
        }
    }
}
