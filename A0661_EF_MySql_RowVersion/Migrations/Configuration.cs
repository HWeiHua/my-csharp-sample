namespace A0661_EF_MySql_RowVersion.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<A0661_EF_MySql_RowVersion.DataAccess.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(A0661_EF_MySql_RowVersion.DataAccess.TestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // ע�⣺ 
            //     ����� DATETIME(6) �� ����� CURRENT_TIMESTAMP(6)
            //     ���� MySQL ֧�ֵ� ������ 6λС��.
            //     ������ӵĻ��� ����ֻ�� "��"��
            string rowVersionSQL = @"ALTER TABLE `test2`.`test_table` 
CHANGE COLUMN `RowVersion` `RowVersion` DATETIME(6) NOT NULL 
DEFAULT CURRENT_TIMESTAMP(6) ON UPDATE CURRENT_TIMESTAMP(6)";

            context.Database.ExecuteSqlCommand(rowVersionSQL);
        }
    }
}
