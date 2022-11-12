using EntityFrameworkCore.Core;
using EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Simple.Admin.Domain.Systems;
using Token.Module.Attributes;
using Token.Module.Helpers;

namespace Simple.Admin.EntityFrameworkCore.Systems
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

        public async Task<List<DictionarySetting>> GetListAsync(string? keywords)
        {
            return await DbContext
                .DictionarySettings
                .WhereIf(keywords.IsNullOrEmpty(), x => EF.Functions.Like(x.Key, $"%{keywords}%"))
                .ToListAsync();
        }
    }
}
