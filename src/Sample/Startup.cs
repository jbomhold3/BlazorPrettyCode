using BlazorPrettyCode;
using BlazorStyled;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Polished;

namespace Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorPrettyCode();
            services.AddBlazorStyled();
            services.AddSingleton<IMixins, Mixins>();
            services.AddSingleton<IShorthand, Shorthand>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
