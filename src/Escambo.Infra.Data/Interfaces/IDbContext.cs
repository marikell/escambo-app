namespace Escambo.Infra.Data.Interfaces
{
    public interface IDbContextProvider
    {
        EscamboContext Context { get; }
    }
}
