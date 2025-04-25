using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DTO
{
    public class ThanhVienDTO
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Branch { get; set; }
        public string Class { get; set; }
        public string Science { get; set; }
        public string MSSV { get; set; }

        public DateTime DateCreate { get; set; }
        public int Status { get; set; } // Thêm thuộc tính này
    }
}
