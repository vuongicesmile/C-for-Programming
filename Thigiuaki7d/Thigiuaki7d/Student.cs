using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    string mssv;
    string hotenlot;
    DateTime ngaysinh;
    string cmnd;
    bool gioitinh;
    string ten;
    string lop;
    string sodt;
    string diachi;
    List<string> monhocdangky;

    public string Mssv
    {
        get
        {
            return mssv;
        }

        set
        {
            mssv = value;
        }
    }

    public string Hotenlot
    {
        get
        {
            return hotenlot;
        }

        set
        {
            hotenlot = value;
        }
    }

    public DateTime Ngaysinh
    {
        get
        {
            return ngaysinh;
        }

        set
        {
            ngaysinh = value;
        }
    }

    public string Cmnd
    {
        get
        {
            return cmnd;
        }

        set
        {
            cmnd = value;
        }
    }

    public bool Gioitinh
    {
        get
        {
            return gioitinh;
        }

        set
        {
            gioitinh = value;
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

    public string Sodt
    {
        get
        {
            return sodt;
        }

        set
        {
            sodt = value;
        }
    }

    public string Diachi
    {
        get
        {
            return diachi;
        }

        set
        {
            diachi = value;
        }
    }

    public List<string> Monhocdangky
    {
        get
        {
            return monhocdangky;
        }

        set
        {
            monhocdangky = value;
        }
    }

    public Student()
    {
        Monhocdangky = new List<string>();
    }
    public Student(string ms,string htl,string ten,bool gt,DateTime ns,
        string lop,string cmnd,string dt,string dc,List<string> mhdky)
    {
        this.Mssv = ms;
        this.Hotenlot = htl;
        this.Ten = ten;
        this.Gioitinh = gt;
        this.Ngaysinh = ns;
        this.Lop = lop;
        this.Cmnd = cmnd;
        this.Sodt = dt;
        this.Diachi = dc;
        this.Monhocdangky = mhdky;
    }
}
