using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DTO
{
    internal class CategoryDeviceDTO
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string DisplayCategory
        {
            get { return $"{CategoryId}-{CategoryName}"; }
        }

        public CategoryDeviceDTO() { }

        public CategoryDeviceDTO(int id, string categoryId, string categoryName)
        {
            Id = id;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public override string ToString()
        {
            return DisplayCategory;
        }
    }
}
