using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class AppSetting
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public int PageSize { get; set; }
    }
}
