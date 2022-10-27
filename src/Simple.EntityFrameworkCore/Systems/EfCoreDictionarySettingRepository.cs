using EntityFrameworkCore.Core;
using Microsoft.EntityFrameworkCore;
using Simple.Domain.Systems;
using Token.Module.Attributes;

namespace Simple.EntityFrameworkCore.Systems
{
    [ExposeServices(typeof(IDictionarySettingRepository))]
    public class EfCoreDictionarySettingRepository : EfCoreRepository<SimpleDbContext, DictionarySetting, Guid>,
        IDictionarySettingRepository
    {
        public EfCoreDictionarySettingRepository(SimpleDbContext dbContext) : base(dbContext)
        {
        }

        public async Task DeleteAsync(Guid id)
        {
            await DbContext.Database.ExecuteSqlRawAsync("DELETE FROM DictionarySettings WHERE Id={0}", id);
        }

        public async Task<DictionarySetting> GetAsync(Guid id)
        {
            return await DbContext.DictionarySettings.FirstAsync(x => x.Id == id);
        }
    }
}
