using Microsoft.Extensions.DependencyInjection;

namespace SharpCommerce.Core.Contracts
{
    public interface IModuleInitializer
    {
        void Init(IServiceCollection serviceCollection);
    }
}
