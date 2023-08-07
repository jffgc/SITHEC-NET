namespace SITHEC.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IHumanRepository HumanRepository { get; }

        Task Save();
    }
}
