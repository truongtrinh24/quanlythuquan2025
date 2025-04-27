using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DTO
{
    internal class DeviceStatusDTO
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        // Thêm property để hiển thị dạng "status_id-status_name"
        public string DisplayStatus
        {
            get { return $"{StatusId}-{StatusName}"; }
        }

        public DeviceStatusDTO() { }

        public DeviceStatusDTO(int statusId, string statusName)
        {
            StatusId = statusId;
            StatusName = statusName;
        }

        public override string ToString()
        {
            return $"{StatusId}-{StatusName}";
        }
    }
}
