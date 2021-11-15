using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SellingPhone.Aplication.DBContext;
using SellingPhone.Aplication.Entities;
using Solution.Data.IServices;

namespace Solution.Data.Services
{
    public class ServiceChiTietSanPham : IServiceChiTietSanPham

    {
    private DBSellingP _DBcontext;
    private List<Chitietsanpham> _lst;

    public ServiceChiTietSanPham()
    {
        _lst = new List<Chitietsanpham>();
        _DBcontext = new DBSellingP();
    }

    public string Add(Chitietsanpham hang)
    {
        try
        {
            _DBcontext.Chitietsanphams.Add(hang);
            Save();
            _lst.Add(hang);
            
            return "Thêm hàng thành công ";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string Delete(Chitietsanpham MaHang)
    {
        try
        {
            _lst.RemoveAt(_lst.FindIndex(c => c.IDChitietsp == MaHang.IDChitietsp));
            _DBcontext.Chitietsanphams.Remove(MaHang);
            Save();
            return "Xóa hàng thành công ";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public List<Chitietsanpham> GetlstBD()
    {
        try
        {
            return _lst = _DBcontext.Chitietsanphams.ToList();
        }
        catch (Exception e)
        {
            return null;
        }

    }

    public string Save()
    {
        try
        {
            _DBcontext.SaveChanges();
            return "Lưu dữ liệu thành công";
        }
        catch (Exception e)
        {
            return e + "";
        }
    }

    public string Update(Chitietsanpham hang)
    {
        try
        {
            _DBcontext.Update(hang);
            Save();
            return "Cập nhật thành công";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    }
}
