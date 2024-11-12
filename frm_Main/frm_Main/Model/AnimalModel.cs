using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Main.Model
{
    public class AnimalModel
    {
        string maThu;
        string tenThu;
        string tenTA;
        string tenKH;
        int slcai;
        int slduc;
        string kieusinh;
        DateTime ngaySinh;
        DateTime ngayVao;
        string hinhanh;
        string machuong;
        int tuoi;
        bool sd;
        string dacdiem;
        string nguongoc;
        string loai;
        

        public AnimalModel()
        {
        }
        public string MaThu { get => maThu; set => maThu = value; }
        public string TenThu { get => tenThu; set => tenThu = value; }
        public string TenTA { get => tenTA; set => tenTA = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int Slcai { get => slcai; set => slcai = value; }
        public int Slduc { get => slduc; set => slduc = value; }
        public string Kieusinh { get => kieusinh; set => kieusinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayVao { get => ngayVao; set => ngayVao = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Machuong { get => machuong; set => machuong = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public bool Sd { get => sd; set => sd = value; }
        public string Dacdiem { get => dacdiem; set => dacdiem = value; }
        public string Nguongoc { get => nguongoc; set => nguongoc = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
