using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SinhVien
{
    string mSSV;
    string hoLot;
    string ten;
    bool gioiTinh;
    DateTime ngaySinh;
    string cMND;
    string soDT;
    string lop;
    string diaChi;
    List<String> monHoc;

    public string MSSV
    {
        get
        {
            return mSSV;
        }

        set
        {
            mSSV = value;
        }
    }

    public string HoLot
    {
        get
        {
            return hoLot;
        }

        set
        {
            hoLot = value;
        }
    }

    public string Ten
    {
        get
        {
            return ten;
        }

        set
        {
            ten = value;
        }
    }

    public bool GioiTinh
    {
        get
        {
            return gioiTinh;
        }

        set
        {
            gioiTinh = value;
        }
    }

    public DateTime NgaySinh
    {
        get
        {
            return ngaySinh;
        }

        set
        {
            ngaySinh = value;
        }
    }

    public string CMND
    {
        get
        {
            return cMND;
        }

        set
        {
            cMND = value;
        }
    }

    public string SoDT
    {
        get
        {
            return soDT;
        }

        set
        {
            soDT = value;
        }
    }

    public string Lop
    {
        get
        {
            return lop;
        }

        set
        {
            lop = value;
        }
    }

    public string DiaChi
    {
        get
        {
            return diaChi;
        }

        set
        {
            diaChi = value;
        }
    }

    public List<string> MonHoc
    {
        get
        {
            return monHoc;
        }

        set
        {
            monHoc = value;
        }
    }

    public SinhVien()
    {
        MonHoc = new List<string>();
    }
    public SinhVien(string ms,bool gt,
        string hl,
        string ten,
        DateTime ns,
        string l
        ,string CM,
        string dt,string dc,List<string>mh)
    {
        this.MSSV = ms;
        this.GioiTinh = gt;
        this.HoLot = hl;
        this.Ten = ten;
        this.NgaySinh = ns;
        this.Lop = l;
        this.CMND = CM;
        this.SoDT = dt;
        this.DiaChi = dc;
        this.MonHoc = mh;
    }
}
