using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string email;
        private string sdt;
        private string diaChi;
        private string hoTen;
        private bool laAdmin;
        private string anhDaiDien;
        private bool trangThai;

        public TaiKhoanDTO()
           
        {
            laAdmin = false;
            anhDaiDien = "";
            trangThai = true;
        }

        public TaiKhoanDTO(string tenTaiKhoan, string matKhau, string email, string sdt, string diaChi, string hoTen, bool laAdmin, string anhDaiDien, bool trangThai)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.email = email;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.hoTen = hoTen;
            this.laAdmin = laAdmin;
            this.anhDaiDien = anhDaiDien;
            this.trangThai = trangThai;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool LaAdmin { get => laAdmin; set => laAdmin = value; }
        public string AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
