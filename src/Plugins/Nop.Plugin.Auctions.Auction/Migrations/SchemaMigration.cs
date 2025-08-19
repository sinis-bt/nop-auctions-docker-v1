using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Auctions.Auction.Domain;

namespace Nop.Plugin.Auctions.Auction.Migrations
{
    [NopMigration("2024/01/01 00:00:00:0000000", "Auctions base schema", MigrationProcessType.Installation)]
    public class SchemaMigration : AutoReversingMigration
    {
        public override void Up()
        {
            Create.TableFor<Domain.Auction>();
            Create.TableFor<Domain.Bid>();
        }
    }
}
