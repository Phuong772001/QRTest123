using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_Dienthoai.Model;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;
using Solution.Data.IServices;
using Solution.Data.Services;

namespace BUS_Dienthoai.Services
{
    public class ServiceChiTietChiTietSanPham : IServices.IServiceChiTietSanPham
    {
        #region Khai Báo

        private IServiceSanPham _sp;
        private IServiceQuocGia _qg;
        private IServiceMauSac _ms;
        private IServiceBoNho _bn;
        private IServiceDoPhanGiai _dpg;
        private IServiceHangDienThoai _hdt;
        private IServiceHeDieuHanh _hdh;
        private IServiceChiTietSanPham _ctsp;

        // thêm iservice nhân viên ở đây

        // thêm lisst nhân viên ở đây
        private List<Sanpham> _lstSanphams;
        private List<Quocgia> _lstQuocgias;
        private List<Mausac> _lstMausacs;
        private List<Bonho> _lstBonhos;
        private List<DoPhanGiai> _lstDoPhanGiais;
        private List<HangDT> _lstHangDts;
        private List<Hedieuhanh> _lstHedieuhanhs;
        private List<Chitietsanpham> _lstChitietsanphams;

        private Sanpham _sanpham;
        private Quocgia _quocgia;
        private Mausac _mausac;
        private Bonho _bonho;
        private DoPhanGiai _doPhanGiai;
        private HangDT _hangDt;
        private Hedieuhanh _hedieuhanh;
        private Chitietsanpham _chitietsanpham;
        private ChiTietSanPhamBUS _chiTietSanPhamBus;

        #endregion

        public ServiceChiTietChiTietSanPham()
        {
            #region Khởi Tạo

            _sp = new Solution.Data.Services.ServiceSanPham();
            _qg = new ServiceQuocGia();
            _ms = new ServiceMauSac();
            _bn = new ServiceBoNho();
            _dpg = new ServiceDoPhanGiai();
            _hdt = new ServiceHangDienThoai();
            _hdh = new ServiceHeDieuHanh();
            _ctsp = new ServiceChiTietSanPham();

            // khởi tạo inter nhân viên ở đây

            _lstSanphams = new List<Sanpham>();
            _lstQuocgias = new List<Quocgia>();
            _lstMausacs = new List<Mausac>();
            _lstBonhos = new List<Bonho>();
            _lstDoPhanGiais = new List<DoPhanGiai>();
            _lstHangDts = new List<HangDT>();
            _lstHedieuhanhs = new List<Hedieuhanh>();
            _lstChitietsanphams = new List<Chitietsanpham>();
            // khởi tạo list nhân viên ở đây

            _sanpham = new Sanpham();
            _quocgia = new Quocgia();
            _mausac = new Mausac();
            _bonho = new Bonho();
            _doPhanGiai = new DoPhanGiai();
            _hangDt = new HangDT();
            _hedieuhanh = new Hedieuhanh();
            _chitietsanpham = new Chitietsanpham();
            _chiTietSanPhamBus = new ChiTietSanPhamBUS();

                #endregion

            // đổ dự liệu lstt nhân viên ở đây
            _lstSanphams = _sp.GetlstBD();
            _lstQuocgias = _qg.GetlstBD();
            _lstMausacs = _ms.GetlstBD();
            _lstBonhos = _bn.GetlstBD();
            _lstDoPhanGiais = _dpg.GetlstBD();
            _lstHangDts = _hdt.GetlstBD();
            _lstHedieuhanhs = _hdh.GetlstBD();
            _lstChitietsanphams = _ctsp.GetlstBD();

        }

        #region Select lst
        public List<ChiTietSanPhamBUS> getlstSP()
        {
            try
            {
                return getlistViewSanPhams();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private List<ChiTietSanPhamBUS> getlistViewSanPhams()
        {

            var lst = (from hdt in _lstHangDts
                    join sp in _lstSanphams on hdt.Id equals sp.IdHang
                    join ctsp in _lstChitietsanphams on sp.Id equals ctsp.IDSanPham
                    join hdh in _lstHedieuhanhs on ctsp.IDHedieuhanh equals hdh.Id
                    join bn in _lstBonhos on ctsp.IDBonho equals bn.Id
                    join dpg in _lstDoPhanGiais on ctsp.IDDophangiai equals dpg.Id
                    join ms in _lstMausacs on ctsp.IDMausac equals ms.Id
                    join qg in _lstQuocgias on ctsp.IDQuocgia equals qg.Id
                    select new
                        ChiTietSanPhamBUS(ctsp, sp, (hdt.Name + " " + sp.Name + " " + ms.Color + " " + bn.Name), hdt.Name, hdh.Name, bn.Name, dpg.Name, ms.Color, qg.Name)
                ).ToList();

            return lst;

        }
        public List<Sanpham> getlistSanPhams()
        {
            return _lstSanphams;
        }
        public List<Bonho> GetlistBonhos()
        {
            return _lstBonhos;
        }
        public List<Hedieuhanh> GetlisthHedieuhanhs()
        {
            return _lstHedieuhanhs;
        }
        public List<DoPhanGiai> GetlistDoPhanGiais()
        {
            return _lstDoPhanGiais;
        }
        public List<Mausac> GetlistMausacs()
        {
            return _lstMausacs;
        }
        public List<HangDT> GetlistHangDts()
        {
            return _lstHangDts;
        }
        public List<Quocgia> GetlistQuocgias()
        {
            return _lstQuocgias;
        }

        #endregion

        #region Thêm 

        public string AddHangDT(HangDT hdt)
        {
            _hdt.Add(hdt);
            return "Thêm thành công";
        }
        public string AddSP(Sanpham hdt)
        {
            _sp.Add(hdt);
            return "Thêm thành công";
        }

        public string AddQG(Quocgia qg)
        {

            _qg.Add(qg);

            return "Thêm thành công";
        }

        public string AddMS(Mausac ms)
        {

            _ms.Add(ms);

            return "Thêm thành công";
        }

        public string AddHDH(Hedieuhanh hdh)
        {

            _hdh.Add(hdh);
            return "Thêm thành công";
        }

        public string AddDPG(DoPhanGiai dpg)
        {

            _dpg.Add(dpg);

            return "Thêm thành công";
        }

        public string AddBN(Bonho bn)
        {

            _bn.Add(bn);

            return "Thêm thành công";
        }

        public string AddCTSP(Chitietsanpham ctsp)
        {
            _ctsp.Add(ctsp);

            return "Thêm thành công";
        }

        #endregion

        #region Sửa

        public string UpdateHangDT(HangDT hdt)
        {

            _hdt.Update(hdt);
            return "Sửa thành công";
        }

        public string UpdateQG(Quocgia qg)
        {
            _qg.Update(qg);

            return "Sửa thành công";
        }

        public string UpdateMS(Mausac ms)
        {
            _ms.Update(ms);

            return "Sửa thành công";
        }

        public string UpdateHDH(Hedieuhanh hdh)
        {

            _hdh.Update(hdh);
            return "Sửa thành công";
        }

        public string UpdateDPG(DoPhanGiai dpg)
        {

            _dpg.Update(dpg);

            return "Sửa thành công";
        }

        public string UpdateBN(Bonho bn)
        {

            _bn.Update(bn);

            return "Sửa thành công";
        }
        public string UpdateSP(Sanpham sp)
        {

            _sp.Update(sp);

            return "Sửa thành công";
        }

        public string UpdateCTSP(Chitietsanpham ctsp)
        {
            _ctsp.Update(ctsp);

            return "Sửa thành công";
        }

        #endregion

        #region Xóa

        public string DeleteHangDT(int key)
        {
            HangDT nv = new HangDT();
            nv = _lstHangDts.FirstOrDefault(c => c.Id == key);
            return _hdt.Delete(nv);
        }

        public string DeleteQG(int key)
        {
            Quocgia nv = new Quocgia();
            nv = _lstQuocgias.FirstOrDefault(c => c.Id == key);
            return _qg.Delete(nv);
        }
        public string DeleteSP(int key)
        {
            Sanpham nv = new Sanpham();
            nv = _lstSanphams.FirstOrDefault(c => c.Id == key);
            return _sp.Delete(nv);
        }

        public string DeleteMS(int key)
        {
            Mausac nv = new Mausac();
            nv = _lstMausacs.FirstOrDefault(c => c.Id == key);
            return _ms.Delete(nv);
        }

        public string DeleteHDH(int key)
        {
            Hedieuhanh nv = new Hedieuhanh();
            nv = _lstHedieuhanhs.FirstOrDefault(c => c.Id == key);
            return _hdh.Delete(nv);
        }

        public string DeleteDPG(int key)
        {
            DoPhanGiai nv = new DoPhanGiai();
            nv = _lstDoPhanGiais.FirstOrDefault(c => c.Id == key);
            return _dpg.Delete(nv);
        }

        public string DeleteBN(int key)
        {
            Bonho nv = new Bonho();
            nv = _lstBonhos.FirstOrDefault(c => c.Id == key);
            return _bn.Delete(nv);
        }

        public string DeleteCTSP(int key)
        {
            Chitietsanpham nv = new Chitietsanpham();
            nv = _lstChitietsanphams.FirstOrDefault(c => c.IDChitietsp == key);
            return _ctsp.Delete(nv);
        }

        #endregion


        #region Tìm kiếm

        public List<ChiTietSanPhamBUS> FindSP(string ten)
        {
            try
            {
                return getlistViewSanPhams().Where(c => c.TenCTSP.Contains(ten)).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<ChiTietSanPhamBUS> Find(string ten)
        {
            try
            {
                return getlistViewSanPhams().Where(c => c.TenHangDT.Contains(ten)
                                                        || c.TenBoNho.Contains(ten)
                                                        || c.TenMau.Contains(ten)
                                                        || c.TenQuocGia.Contains(ten)
                                                        || c.TenDoPhanGiai.Contains(ten)
                                                        || c.TenHeDieuHanh.Contains(ten)).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        #endregion

        

        #region Select Id

        public int selectsSanpham(string mahang)
        {
            if (_lstSanphams.Any(c => c.Name == mahang))
            {
                return _lstSanphams.Where(c => c.Name == mahang).Select(c => c.Id).FirstOrDefault();
            }
            else
            {
                return -1;
            }
        }

        public int selectHangDt(string mahang)
        {
            if (_lstHangDts.Any(c => c.Name == mahang))
            {
                return _lstHangDts.Where(c => c.Name == mahang).Select(c => c.Id).FirstOrDefault();
            }
            else
            {
                return -1;
            }
        }

        public int selecthHedieuhanh(string mahang)
        {
            if (_lstHedieuhanhs.Any(c => c.Name == mahang))
            {
                return _lstHedieuhanhs.Where(c => c.Name == mahang).Select(c => c.Id).FirstOrDefault();
            }
            else
            {
                return -1;
            }
        }

        public int selectDoPhanGiai(string mahang)
        {
            if (_lstDoPhanGiais.Any(c => c.Name == mahang))
            {
                return _lstDoPhanGiais.Where(c => c.Name == mahang).Select(c => c.Id).FirstOrDefault();
            }
            else
            {
                return -1;
            }
        }

        public int selectMausac(string mahang)
        {
            if (_lstMausacs.Any(c => c.Color == mahang))
            {
                return _lstMausacs.Where(c => c.Color == mahang).Select(c => c.Id).FirstOrDefault();
            }
            else
            {
                return -1;
            }
        }

        public int selectBonho(string mahang)
        {
            if (_lstBonhos.Any(c => c.Name == mahang))
            {
                return _lstBonhos.Where(c => c.Name == mahang).Select(c => c.Id).FirstOrDefault();
            }
            else
            {
                return -1;
            }
        }

        public int selectQuocgia(string mahang)
        {
            if (_lstQuocgias.Any(c => c.Name == mahang))
            {
                return _lstQuocgias.Where(c => c.Name == mahang).Select(c => c.Id).FirstOrDefault();
            }
            else
            {
                return -1;
            }

        }

        #endregion


        #region Select Đối tượng

        public Sanpham selectsSanphamUP(int mahang)
        {
            return _lstSanphams.FirstOrDefault(c => c.Id == mahang);
        }

        public HangDT selectHangDtUP(int mahang)
        {
            return _lstHangDts.FirstOrDefault(c => c.Id == mahang);
        }

        public Hedieuhanh selecthHedieuhanhUP(int mahang)
        {
            return _lstHedieuhanhs.FirstOrDefault(c => c.Id == mahang);
        }

        public DoPhanGiai selectDoPhanGiaiUP(int mahang)
        {
            return _lstDoPhanGiais.FirstOrDefault(c => c.Id == mahang);
        }

        public Mausac selectMausacUP(int mahang)
        {
            return _lstMausacs.FirstOrDefault(c => c.Id == mahang);
        }

        public Bonho selectBonhoUP(int mahang)
        {
            return _lstBonhos.FirstOrDefault(c => c.Id == mahang);
        }

        public Quocgia selectQuocgiaUP(int mahang)
        {
            return _lstQuocgias.FirstOrDefault(c => c.Id == mahang);
        }

        public Chitietsanpham selectChitietsanphamUP(int mahang)
        {
            return _lstChitietsanphams.FirstOrDefault(c => c.IDChitietsp == mahang);

        }

        #endregion



    }
}
