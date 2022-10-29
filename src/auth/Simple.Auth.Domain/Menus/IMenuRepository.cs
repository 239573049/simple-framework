using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Simple.Shared.Base;

namespace Simple.Auth.Domain.Menus
{
    public interface IMenuRepository : IRepository<Menu, Guid>
    {
        /// <summary>
        /// 获取用户可访菜单
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        Task<List<Menu>> GetUserMenuAsync(string keywords, IEnumerable<Guid> roleIds);
    }
}