using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BUS
{
    public class LoaiSPService
    {
        public List<LoaiSP> GetAll()
        {
            using (var context = new ProductContextDB())
            {
                return context.LoaiSPs.ToList();
            }
        }
    }
}
