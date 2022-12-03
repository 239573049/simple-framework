using NSwag.Annotations;

namespace Simple.Application.Contract
{
    public class PagedRequestDto
    {

        private int _page = 1;
        private int _pageSize = 20;

        /// <summary>
        /// 页码, 默认1
        /// </summary>
        public int Page
        {
            get => _page;
            set => _page = value <= 0 ? 1 : value;
        }

        /// <summary>
        /// 页大小, 默认20
        /// </summary>
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value <= 0 ? 20 : value;
        }

        /// <summary>
        /// 忽略. 只传 Page 和 PageSize
        /// </summary>
        [OpenApiIgnore]
        public int SkipCount => (Page - 1) * MaxResultCount;

        /// <summary>
        /// 忽略. 只传 Page 和 PageSize
        /// </summary
        [OpenApiIgnore]
        public int MaxResultCount =>
            PageSize > 1000
                ? 1000
                : PageSize;
    }
}