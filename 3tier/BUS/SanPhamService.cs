using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace BUS
{
    public class SanPhamService
    {
        public List<Sanpham> GetAll()
        {
            using (var context = new ProductContextDB())
            {
                return context.Sanphams.Include("LoaiSP").ToList();
            }
        }
        public void InsertOrUpdate(Sanpham sanPham)
        {
            using (var context = new ProductContextDB())
            {
                context.Sanphams.AddOrUpdate(sanPham);
                context.SaveChanges();
            }
        }
        public void Delete(string maSP)
        {
            using (var context = new ProductContextDB())
            {
                var sanPham = context.Sanphams.FirstOrDefault(sp => sp.MaSP == maSP);
                if (sanPham != null)
                {
                    context.Sanphams.Remove(sanPham);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Sản phẩm không tồn tại.");
                }
            }
        }

    }
}
