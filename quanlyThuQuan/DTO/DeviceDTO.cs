using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DTO
{
    internal class DeviceDTO
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public int StatusId { get; set; }

        public string StatusName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CategoryId { get; set; }  // Thêm thuộc tính CategoryId
        public string CategoryName { get; set; }  // Thêm thuộc tính CategoryName
        public int IsDeleted { get; set; } // Thêm thuộc tính này
    }
}
