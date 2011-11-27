using System.Web.Mvc;
using Dto;
using Moq;
using NUnit.Framework;
using Service;
using Tests.Utility;
using UI.Controllers;

namespace Tests.UI.Controllers
{
    public class AuditTemplateControllerSpecs 
    {
        public class When_creating_a_audit_template : ContextSpec<AuditTemplateController>
        {
            private AuditTemplateDto dto;
            private RedirectToRouteResult result;
            private Mock<ICreateAuditTemplateCommand> createAuditTemplate;

            protected override AuditTemplateController CreateSut()
            {
                createAuditTemplate = new Mock<ICreateAuditTemplateCommand>();
                return new AuditTemplateController(createAuditTemplate.Object);
            }

            protected override void UnderTheseConditions()
            {
                dto = new AuditTemplateDto();
            }

            protected override void BecauseOf()
            {
                result = Sut.Create(dto);
            }

            [Test]
            public void the_create_command_should_have_executed()
            {
                createAuditTemplate.Verify(x=>x.Execute(dto));
            }

            [Test]
            public void it_should_display_the_index_view()
            {
                result.RouteValues["action"].ShouldBeEqualTo("Index");
            }
        }
    }
}