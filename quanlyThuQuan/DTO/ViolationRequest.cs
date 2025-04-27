using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DTO
{
    public class ViolationRequest
    {
        public int? BookingId { get; set; } 
        public int? UserId { get; set; }
        public int? DeviceId { get; set; }
    }
}
