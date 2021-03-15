using NguyenHoangNhat_5951071069.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenHoangNhat_5951071069.Controllers
{
    public class StudentController : ApiController
    {
        public StudentInfo Get()
        {
            var Nhatcute= new StudentInfo
            {
                TenSinhVien = $"Nguyen Hoang Nhat",
                MaSinhVien = $"5951071069",
                NgaySinh = $"02/01/2000",
                QueQuan = $"Ha Tinh"

            };
            return Nhatcute;
        }

    }
}
