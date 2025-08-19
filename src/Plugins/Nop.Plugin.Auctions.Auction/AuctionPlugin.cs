using Nop.Services.Plugins;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.Auctions.Auction
{
    public class AuctionPlugin : BasePlugin, IAdminMenuPlugin
    {
        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }

        public Task ManageSiteMapAsync(AdminMenuItem rootNode)
        {
            var menuItem = new AdminMenuItem
            {
                SystemName = "Auctions",
                Title = "Auctions",
                ControllerName = "AuctionsAdmin",
                ActionName = "List",
                IconClass = "fa-dot-circle-o",
            };

            var catalogMenuItem = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Catalog");
            if (catalogMenuItem != null)
            {
                catalogMenuItem.ChildNodes.Add(menuItem);
            }
            else
            {
                rootNode.ChildNodes.Add(menuItem);
            }

            return Task.CompletedTask;
        }
    }
}
