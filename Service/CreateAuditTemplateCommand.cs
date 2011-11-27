using Dto;

namespace Service
{
    public interface ICreateAuditTemplateCommand
    {
        void Execute(AuditTemplateDto dto);
    }

    public class CreateAuditTemplateCommand : ICreateAuditTemplateCommand
    {
        public void Execute(AuditTemplateDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}