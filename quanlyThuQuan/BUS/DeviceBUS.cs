using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.BUS
{
    internal class DeviceBUS
    {
        private DeviceDAL deviceDAL = new DeviceDAL();

        // Lấy danh sách tất cả thiết bị
        public List<DeviceDTO> GetAllDevices()
        {
            try
            {
                return deviceDAL.GetAllDevices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<DeviceDTO>();
            }
        }
        // Lấy danh sách trạng thái thiết bị
        public List<DeviceStatusDTO> GetDeviceStatuses()
        {
            try
            {
                return deviceDAL.GetDeviceStatuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<DeviceStatusDTO>();
            }
        }
        // Lấy danh sách danh mục thiết bị
        public List<CategoryDeviceDTO> GetDeviceCategories()
        {
            try
            {
                return deviceDAL.GetDeviceCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CategoryDeviceDTO>();
            }
        }

        // Thêm thiết bị mới
        public bool AddDevice(DeviceDTO device)
        {
            try
            {
                // Kiểm tra logic nghiệp vụ
                if (string.IsNullOrWhiteSpace(device.DeviceName))
                {
                    throw new Exception("Tên thiết bị không được để trống!");
                }

                // Kiểm tra category_id
                if (!string.IsNullOrWhiteSpace(device.CategoryId))
                {
                    var validCategories = deviceDAL.GetDeviceCategories();
                    if (!validCategories.Any(c => c.CategoryId == device.CategoryId))
                    {
                        throw new Exception($"Danh mục thiết bị không hợp lệ: {device.CategoryId}. Các giá trị hợp lệ: {string.Join(", ", validCategories.Select(c => c.CategoryId))}");
                    }
                }

                // Nếu description trống, gán giá trị mặc định
                if (string.IsNullOrWhiteSpace(device.Description))
                {
                    device.Description = "Không có mô tả";
                }

                return deviceDAL.AddDevice(device);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm thiết bị: {ex.Message}");
            }
        }
        public DeviceDTO GetDeviceByID(int deviceID)
        {
            try
            {
                DeviceDTO device = deviceDAL.GetDeviceById(deviceID);
                if (device == null)
                {
                    throw new Exception("Không tìm thấy thiết bị với ID: " + deviceID);
                }
                return device;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin thiết bị: " + ex.Message);
            }
        }
        public bool UpdateDevice(DeviceDTO device)
        {
            // Kiểm tra logic nghiệp vụ
            if (string.IsNullOrWhiteSpace(device.DeviceName))
            {
                throw new Exception("Tên thiết bị không được để trống!");
            }
            if (string.IsNullOrWhiteSpace(device.Description))
            {
                throw new Exception("Mô tả thiết bị không được để trống!");
            }

            try
            {
                return deviceDAL.UpdateDevice(device);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thiết bị: " + ex.Message);
            }
        }
        public bool DeleteDevice(int deviceId)
        {
            try
            {
                // Kiểm tra xem thiết bị có đang được mượn không
                if (deviceDAL.IsDeviceBeingBorrowed(deviceId))
                {
                    throw new Exception("Không thể xóa thiết bị vì thiết bị đang được mượn!");
                }

                return deviceDAL.DeleteDevice(deviceId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thiết bị: " + ex.Message);
            }
        }
        public bool SoftDeleteDevicesByCategory(string categoryId)
        {
            // Lấy danh sách thiết bị thuộc mã quy định và chưa bị xóa mềm
            var devices = deviceDAL.GetAllDevices().Where(d => d.CategoryId == categoryId && d.IsDeleted == 0).ToList();

            // Kiểm tra xem có thiết bị nào đang được mượn không
            List<string> borrowedDevices = new List<string>();
            foreach (var device in devices)
            {
                if (deviceDAL.IsDeviceBorrowed(device.DeviceId))
                {
                    borrowedDevices.Add($"Thiết bị '{device.DeviceName}' (ID: {device.DeviceId})");
                }
            }

            if (borrowedDevices.Any())
            {
                throw new Exception($"Không thể xóa! Các thiết bị sau đang được mượn:\n{string.Join("\n", borrowedDevices)}");
            }

            // Nếu không có thiết bị nào đang được mượn, thực hiện xóa mềm
            return deviceDAL.SoftDeleteDevicesByCategory(categoryId);
        }
        public List<DeviceDTO> SearchDevices(string keyword = "", string categoryId = "")
        {
            return deviceDAL.SearchDevices(keyword, categoryId);
        }

    }
}

