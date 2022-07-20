using ApiShopee.MongoDB;
using Xunit;

namespace ApiShopee;

[CollectionDefinition(ApiShopeeTestConsts.CollectionDefinitionName)]
public class ApiShopeeWebCollection : ApiShopeeMongoDbCollectionFixtureBase
{

}
