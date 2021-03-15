using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NguyenHoangNhat_5951071069.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "tenSinhVien")]
        public string TenSinhVien { get; set; }
        [DataMember(Name = "maSinhVien")]
        public string MaSinhVien { get; set; }
        [DataMember(Name = "ngaySinh")]
        public string NgaySinh { get; set; }
        [DataMember(Name = "queQuan")]
        public string QueQuan { get; set; }

    }
}