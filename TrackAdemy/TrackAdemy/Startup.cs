using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackAdemy.Startup))]
namespace TrackAdemy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
