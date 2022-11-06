using System;

namespace Simple.Application.Contract
{
    public class SimpleInput : PagedRequestDto
    {
        /// <summary>
        /// 关键词
        /// </summary>
        public string? Keywords { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }

}
