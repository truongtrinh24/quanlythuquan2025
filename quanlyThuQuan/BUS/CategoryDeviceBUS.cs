using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.BUS
{
    internal class CategoryDeviceBUS
    {
        private CategoryDeviceDAL categoryDAL;

        public CategoryDeviceBUS()
        {
            categoryDAL = new CategoryDeviceDAL();
        }

        public List<CategoryDeviceDTO> GetAllCategories()
        {
            return categoryDAL.GetAllCategories();
        }

        public bool AddCategory(CategoryDeviceDTO category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryId))
            {
                throw new Exception("Mã quy định không được để trống!");
            }

            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                throw new Exception("Tên quy định không được để trống!");
            }

            // Kiểm tra xem category_id đã tồn tại chưa
            var existingCategories = GetAllCategories();
            if (existingCategories.Any(c => c.CategoryId == category.CategoryId))
            {
                throw new Exception($"Mã quy định '{category.CategoryId}' đã tồn tại!");
            }

            return categoryDAL.AddCategory(category);
        }
    }
}
