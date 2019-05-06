using SimpleInjector;

namespace Escambo.Infra.CrossCutting.IoC.Interfaces
{
    public interface IIoC
    {
        void Register(Container container);
    }
}
