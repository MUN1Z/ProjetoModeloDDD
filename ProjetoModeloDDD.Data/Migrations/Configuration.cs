using ProjetoModeloDDD.Data.Context;
using System.Data.Entity.Migrations;

namespace ProjetoModeloDDD.Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoModeloDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoModeloDDDContext context)
        {
        }
    }
}
