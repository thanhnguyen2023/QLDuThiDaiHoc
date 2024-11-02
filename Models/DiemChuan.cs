using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DiemChuan
    {
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }
        public string TenTruong { get; set; }
       
        public float TongDiem { get; set; }

        public int ChiTieu { get; set; }
        public String getTenNganh()
        {
            return TenNganh;
        }
    }
}
