using System.Web.UI;
using System.Web.UI.Adapters;

namespace JB.ControlAdapters
{
    /// <summary>
    /// Page Session can be potentially pushed
    /// over to the server to avoid too much page data
    /// </summary>
    public class MyPageAdapter : PageAdapter
    {
        /*public override PageStatePersister GetStatePersister()
        {
            return new SessionPageStatePersister(Page);
        }
         */
    }
}