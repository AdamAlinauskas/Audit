namespace Service
{
    public interface ICreateAuditTemplateCommand
    {
        void Execute();
    }

    public class CreateAuditTemplateCommand : ICreateAuditTemplateCommand
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}