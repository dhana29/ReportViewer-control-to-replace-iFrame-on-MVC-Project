using Microsoft.Owin;
using Owin;

namespace SSRSReportViewByiFrame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
