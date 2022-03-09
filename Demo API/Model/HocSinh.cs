using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Demo_API.Model
{
    public class HocSinh
    {
        public int HocSinhId { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public int? LopId { get; set; }
        public Lop Lop { get; set; }
    }
}
