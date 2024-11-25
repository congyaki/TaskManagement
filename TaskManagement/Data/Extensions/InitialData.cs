using Microsoft.AspNetCore.Identity;
using System.Net;
using TaskManagement.Entities;
using TaskManagement.enums;
using TaskStatus = TaskManagement.enums.TaskStatus;

namespace TaskManagement.Data.Extensions
{
    internal class InitialData
    {
        public static IEnumerable<User> Users => new List<User>()
        {
            new() {
                UserName = "Admin",
                Code = "01",
                FirstName = "Đức Công",
                LastName = "Đỗ",
                Email = "admin@example.com",
                EmailConfirmed = true,
                DepartmentId = 1,
            },
            new() {
                UserName = "User01",
                Code = "02",
                FirstName = "Thiên Long",
                LastName = "Vũ",
                Email = "user@example.com",
                EmailConfirmed = true,
                DepartmentId = 2,
            }

        };

        public static IEnumerable<Role> Roles => new List<Role>()
        {
            new("Admin"),
            new("Trưởng khoa"),
            new("Phó Khoa"),
            new("Admin"),
            new("Trưởng bộ môn CĐS"),
            new("Giảng viên"),
            new("User")

        };

        public static IEnumerable<TblDmDepartment> Departments => new List<TblDmDepartment>()
        {
            new() { Code = "CDS", Name = "Chuyển đổi số", Description = "Môn chuyển đổi số", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "AI", Name = "Trí tuệ nhân tạo", Description = "Môn trí tuệ nhân tạo", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "CS", Name = "Khoa học máy tính", Description = "Môn khoa học máy tính", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "DS", Name = "Khoa học dữ liệu", Description = "Môn khoa học dữ liệu", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "ML", Name = "Máy học", Description = "Môn máy học", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "SE", Name = "Kỹ thuật phần mềm", Description = "Môn kỹ thuật phần mềm", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "IS", Name = "Hệ thống thông tin", Description = "Môn hệ thống thông tin", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "NT", Name = "Mạng và truyền thông", Description = "Môn mạng và truyền thông", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "UI", Name = "Thiết kế giao diện", Description = "Môn thiết kế giao diện", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "UX", Name = "Trải nghiệm người dùng", Description = "Môn trải nghiệm người dùng", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "PM", Name = "Quản lý dự án", Description = "Môn quản lý dự án", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "DB", Name = "Cơ sở dữ liệu", Description = "Môn cơ sở dữ liệu", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "OS", Name = "Hệ điều hành", Description = "Môn hệ điều hành", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "NW", Name = "Mạng máy tính", Description = "Môn mạng máy tính", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "SD", Name = "Phát triển phần mềm", Description = "Môn phát triển phần mềm", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "QA", Name = "Đảm bảo chất lượng", Description = "Môn đảm bảo chất lượng", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "RM", Name = "Quản lý rủi ro", Description = "Môn quản lý rủi ro", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "SC", Name = "An toàn thông tin", Description = "Môn an toàn thông tin", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "CN", Name = "Điện toán đám mây", Description = "Môn điện toán đám mây", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "BC", Name = "Blockchain", Description = "Môn blockchain", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 }

        };

        public static IEnumerable<TblDmLabel> Labels => new List<TblDmLabel>()
        {
            new() { Code = "CTDT", Name = "Chương trình đào tạo", Color = "#FFDDC1", Description = "Chương trình đào tạo", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "HOC_TAP", Name = "Học tập", Color = "#B3E5FC", Description = "Học tập", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "NGHIEN_CUU", Name = "Nghiên cứu", Color = "#FFABAB", Description = "Nghiên cứu khoa học", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "THUC_TAP", Name = "Thực tập", Color = "#FFECB3", Description = "Thực tập sinh viên", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "DO_AN", Name = "Đồ án", Color = "#C5E1A5", Description = "Dự án học tập", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "KY_THI", Name = "Kỳ thi", Color = "#FFE0B2", Description = "Kỳ thi và kiểm tra", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "TU_VAN", Name = "Tư vấn", Color = "#B39DDB", Description = "Tư vấn học tập", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "HOI_THAO", Name = "Hội thảo", Color = "#FFCDD2", Description = "Hội thảo khoa học", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "CONG_TAC", Name = "Công tác", Color = "#F8BBD0", Description = "Công tác tổ chức", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "TUYEN_DUNG", Name = "Tuyển dụng", Color = "#BBDEFB", Description = "Tuyển dụng sinh viên", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "PHONG_THAI", Name = "Phong thái", Color = "#FFF9C4", Description = "Phong thái chuyên nghiệp", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "NGON_NGU", Name = "Ngôn ngữ", Color = "#E1BEE7", Description = "Ngôn ngữ học", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "KIEN_THUC", Name = "Kiến thức", Color = "#C8E6C9", Description = "Kiến thức nền tảng", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "KY_NANG", Name = "Kỹ năng", Color = "#FFD180", Description = "Kỹ năng học tập", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "GIAO_TIEP", Name = "Giao tiếp", Color = "#FFF59D", Description = "Kỹ năng giao tiếp", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "TU_DUY", Name = "Tư duy", Color = "#FFCCBC", Description = "Tư duy logic", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "SANG_TAO", Name = "Sáng tạo", Color = "#D1C4E9", Description = "Tư duy sáng tạo", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "KY_LUAT", Name = "Kỷ luật", Color = "#DCEDC8", Description = "Tính kỷ luật", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "SU_KIEN", Name = "Sự kiện", Color = "#FFE082", Description = "Sự kiện học tập", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "NGHIEN_CUU_KH", Name = "Nghiên cứu khoa học", Color = "#FFAB91", Description = "Nghiên cứu khoa học", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 },
            new() { Code = "THUC_HANH", Name = "Thực hành", Color = "#FFCC80", Description = "Thực hành và thực tế", CreatedAt = DateTime.Now, CreatedBy = 0, LastModifiedAt = DateTime.Now, LastModifiedBy = 0 }

        };

        public static IEnumerable<TblTask> Tasks => new List<TblTask>()
        {
            new() { Title = "Hoàn thành tài liệu dự án", Code = "NV_001", Description = "Chuẩn bị và hoàn tất tất cả tài liệu dự án.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.NotAssigned },
            new() { Title = "Phát triển module xác thực", Code = "NV_002", Description = "Triển khai xác thực và phân quyền người dùng.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(14), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Assigned },
            new() { Title = "Tối ưu hóa cơ sở dữ liệu", Code = "NV_003", Description = "Tối ưu hóa các truy vấn cơ sở dữ liệu để tăng hiệu suất.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(10), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Received },
            new() { Title = "Đánh giá thiết kế giao diện", Code = "NV_004", Description = "Đánh giá thiết kế giao diện người dùng.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.InProgress },
            new() { Title = "Viết kiểm thử đơn vị", Code = "NV_005", Description = "Viết các kiểm thử đơn vị cho các module cốt lõi.", StartDate = DateTime.Now.AddHours(-2), EndDate = DateTime.Now.AddHours(3), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Completed },
            new() { Title = "Sửa lỗi", Code = "NV_006", Description = "Sửa các lỗi phát hiện trong giai đoạn kiểm thử.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(4), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.InProgress },
            new() { Title = "Tái cấu trúc mã nguồn", Code = "NV_007", Description = "Tái cấu trúc mã nguồn để cải thiện khả năng đọc và hiệu suất.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(8), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Tích hợp API", Code = "NV_008", Description = "Tích hợp các API của bên thứ ba.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(12), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.UnStatisfactory },
            new() { Title = "Chuẩn bị báo cáo dự án", Code = "NV_009", Description = "Biên soạn và hoàn tất báo cáo dự án.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(6), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Completed },
            new() { Title = "Kiểm toán bảo mật", Code = "NV_010", Description = "Thực hiện kiểm toán bảo mật cho các module.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(11), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Thiết lập pipeline CI/CD", Code = "NV_011", Description = "Cấu hình tích hợp liên tục và triển khai liên tục.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(9), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Viết tài liệu API", Code = "NV_012", Description = "Viết tài liệu cho các API.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Tổ chức buổi đào tạo người dùng", Code = "NV_013", Description = "Tổ chức buổi đào tạo cho người dùng mới.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Kiểm thử hiệu suất", Code = "NV_014", Description = "Kiểm thử hiệu suất hệ thống dưới tải cao.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Lên ý tưởng tính năng mới", Code = "NV_015", Description = "Thảo luận và lên ý tưởng cho các tính năng mới với nhóm.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Khắc phục giao diện không nhất quán", Code = "NV_016", Description = "Khắc phục các lỗi không nhất quán trong giao diện.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(6), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Di chuyển cơ sở dữ liệu", Code = "NV_017", Description = "Di chuyển dữ liệu sang cấu trúc cơ sở dữ liệu mới.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(13), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Cải thiện khả năng truy cập", Code = "NV_018", Description = "Cải thiện khả năng truy cập trong ứng dụng.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(4), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Họp với khách hàng để phản hồi", Code = "NV_019", Description = "Thảo luận các phản hồi từ khách hàng.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed },
            new() { Title = "Thiết lập công cụ giám sát", Code = "NV_020", Description = "Cài đặt giám sát và cảnh báo cho môi trường sản xuất.", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(10), Priority = TaskPriority.Fairly, CreatedAt = DateTime.Now, CreatedBy = 0, Status = TaskStatus.Confirmed }
        };

        public static IEnumerable<TaskLabel> TaskLabels => new List<TaskLabel>()
        {
            new() { TaskId = 1, LabelId = 1 },
            new() { TaskId = 1, LabelId = 2 },
            new() { TaskId = 2, LabelId = 3 },
            new() { TaskId = 2, LabelId = 4 },
            new() { TaskId = 3, LabelId = 5 },
            new() { TaskId = 3, LabelId = 6 },
            new() { TaskId = 4, LabelId = 7 },
            new() { TaskId = 4, LabelId = 8 },
            new() { TaskId = 5, LabelId = 9 },
            new() { TaskId = 5, LabelId = 10 },
            new() { TaskId = 6, LabelId = 11 },
            new() { TaskId = 6, LabelId = 12 },
            new() { TaskId = 7, LabelId = 13 },
            new() { TaskId = 7, LabelId = 14 },
            new() { TaskId = 8, LabelId = 15 },
            new() { TaskId = 8, LabelId = 16 },
            new() { TaskId = 9, LabelId = 17 },
            new() { TaskId = 9, LabelId = 18 },
            new() { TaskId = 10, LabelId = 19 },
            new() { TaskId = 10, LabelId = 20 },
            new() { TaskId = 11, LabelId = 1 },
            new() { TaskId = 11, LabelId = 3 },
            new() { TaskId = 12, LabelId = 4 },
            new() { TaskId = 12, LabelId = 6 },
            new() { TaskId = 13, LabelId = 2 },
            new() { TaskId = 13, LabelId = 7 },
            new() { TaskId = 14, LabelId = 5 },
            new() { TaskId = 14, LabelId = 9 },
            new() { TaskId = 15, LabelId = 8 },
            new() { TaskId = 15, LabelId = 10 },
            new() { TaskId = 16, LabelId = 11 },
            new() { TaskId = 16, LabelId = 13 },
            new() { TaskId = 17, LabelId = 14 },
            new() { TaskId = 17, LabelId = 16 },
            new() { TaskId = 18, LabelId = 12 },
            new() { TaskId = 18, LabelId = 18 },
            new() { TaskId = 19, LabelId = 19 },
            new() { TaskId = 19, LabelId = 17 },
            new() { TaskId = 20, LabelId = 15 },
            new() { TaskId = 20, LabelId = 20 }
        };

    }
}
