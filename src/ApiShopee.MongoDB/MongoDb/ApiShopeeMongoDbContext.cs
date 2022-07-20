using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ApiShopee.MongoDB;

[ConnectionStringName("Default")]
public class ApiShopeeMongoDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
