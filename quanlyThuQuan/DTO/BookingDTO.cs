using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DTO
{
    internal class BookingDTO
    {
        public int BookingId { get; set; } // Thêm thuộc tính này
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ActualTime { get; set; }
    }
}
