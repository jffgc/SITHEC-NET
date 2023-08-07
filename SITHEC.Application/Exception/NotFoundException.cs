namespace SITHEC.Application.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"{name} ({key}) No fue encontrado")
        {

        }
    }
}
