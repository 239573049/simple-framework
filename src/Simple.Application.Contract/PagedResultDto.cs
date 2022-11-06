using System.Collections.Generic;

namespace Simple.Application.Contract
{
    public class PagedResultDto<T>
    {
        public IReadOnlyList<T> Items { get; set; } = null!;

        public long TotalCount { get; set; }

        public PagedResultDto()
        {
        }

        public PagedResultDto(long totalCount, IReadOnlyList<T> items)
        {
            TotalCount = totalCount;
            Items = items;
        }
    }
}