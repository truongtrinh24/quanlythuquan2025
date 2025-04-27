using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DTO
{
    public class ViolationDTO
    {
        public int? ViolationId { get; set; }
        public int? UserId { get; set; }
        public int? DeviceId { get; set; }
        public int? BookingId { get; set; }
        public string? Description { get; set; }
        public decimal? FineAmount { get; set; }
        public DateTime? ViolationTime { get; set; }
        
    
        public override string ToString()
        {
            return $"ViolationId: {ViolationId}\n" +
                   $"UserId: {UserId}\n" +
                   $"DeviceId: {DeviceId}\n" +
                   $"BookingId: {BookingId}\n" +
                   $"Description: {Description}\n" +
                   $"FineAmount: {FineAmount}\n" +
                   $"ViolationTime: {ViolationTime}\n";

        }
    }
}
