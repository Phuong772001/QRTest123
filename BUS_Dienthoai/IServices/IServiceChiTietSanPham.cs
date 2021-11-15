using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_Dienthoai.Model;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace BUS_Dienthoai.IServices
{
    public interface IServiceChiTietSanPham
    {
        // string AddCTSP( Quocgia qg, Mausac ms, Hedieuhanh hdh, DoPhanGiai dpg, Bonho bn, Sanpham sp,
        //Chitietsanpham ctsp);

        #region Thêm

        string AddHangDT(HangDT hdt);
        string AddSP(Sanpham hdt);
        string AddQG(Quocgia qg);
        string AddMS(Mausac ms);
        string AddHDH(Hedieuhanh hdh);
        string AddDPG(DoPhanGiai dpg);
        string AddBN(Bonho bn);
        string AddCTSP(Chitietsanpham ctsp);

        #endregion


        #region Sửa

        string UpdateHangDT(HangDT hdt);
        string UpdateQG(Quocgia qg);
        string UpdateMS(Mausac ms);
        string UpdateHDH(Hedieuhanh hdh);
        string UpdateDPG(DoPhanGiai dpg);
        string UpdateBN(Bonho bn);
        string UpdateSP(Sanpham sp);
        string UpdateCTSP(Chitietsanpham ctsp);

        #endregion



        #region Xóa
        string DeleteHangDT(int key);
        string DeleteQG(int key);
        string DeleteSP(int key);
        string DeleteMS(int key);
        string DeleteHDH(int key);
        string DeleteDPG(int key);
        string DeleteBN(int key);
        string DeleteCTSP(int key);

        #endregion

        #region Tìm kiếm


        List<ChiTietSanPhamBUS> FindSP(string ten);
        List<ChiTietSanPhamBUS> Find(string ten);
        #endregion



        #region Select Id

        int selectsSanpham(string mahang);
        int selectHangDt(string mahang);
        int selecthHedieuhanh(string mahang);
        int selectDoPhanGiai(string mahang);
        int selectMausac(string mahang);
        int selectBonho(string mahang);
        int selectQuocgia(string mahang);

        #endregion


        #region Select đối tượng

        Sanpham selectsSanphamUP(int mahang);
        HangDT selectHangDtUP(int mahang);
        Hedieuhanh selecthHedieuhanhUP(int mahang);
        DoPhanGiai selectDoPhanGiaiUP(int mahang);
        Mausac selectMausacUP(int mahang);
        Bonho selectBonhoUP(int mahang);
        Quocgia selectQuocgiaUP(int mahang);
        Chitietsanpham selectChitietsanphamUP(int mahang);

        #endregion


        #region Select lst
        List<ChiTietSanPhamBUS> getlstSP();
        public List<Sanpham> getlistSanPhams();
        public List<Bonho> GetlistBonhos();
        public List<Hedieuhanh> GetlisthHedieuhanhs();
        public List<DoPhanGiai> GetlistDoPhanGiais();
        public List<Mausac> GetlistMausacs();
        public List<HangDT> GetlistHangDts();
        public List<Quocgia> GetlistQuocgias();

        #endregion


    }
}
