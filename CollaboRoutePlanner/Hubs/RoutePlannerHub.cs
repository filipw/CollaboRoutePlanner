using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace CollaboRoutePlanner.Hubs
{
    [HubName("routeplanner")]
    public class RoutePlannerHub : Hub
    {
        public void refreshRoute(dynamic directions)
        {
            Clients.Others.refreshRoutes(directions);
        }
    }
}