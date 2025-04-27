using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.BUS
{
    public class ViolateBUS
    {
        private ViolateDAL violationDAL = new ViolateDAL();
        public List<ViolationDTO> GetAllViolations()
        {
            return violationDAL.GetAllViolations();
        }
        public void UpdateViolation(ViolationDTO violation)
        {
            violationDAL.UpdateViolation(violation);
        }
        public void AddViolation(ViolationDTO violation)
        {
            violationDAL.AddViolation(violation);
        }
        public void DeleteViolation(int? violationId)
        {
            violationDAL.DeleteViolation(violationId);
        }
        public void UpdateUserStatus(int? userId,byte status)
        {
            violationDAL.UpdateUserStatus(userId,status);
        }
        public List<ViolationDTO> getViolationByUserId(int? userId)
        {
           return violationDAL.GetViolationsByUserId(userId);
        }
        public  List<BookingDTO> GetLateBookings()
        {
           return violationDAL.GetLateBookings();
        }
    }
}
