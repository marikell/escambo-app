using SimpleInjector;

namespace Escambo.Infra.CrossCutting.IoC.Interfaces
{
    public interface IIoCRegister
    {
        void Register(Container container);
    }
}
