using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thigiuaki7d;
using System.Globalization;

public class StudentManagement
{
    public List<Student> danhsachsinhvien;

    public StudentManagement()
    {
        danhsachsinhvien = new List<Student>();
    }
    public Student this[int index]
    {
        get { return danhsachsinhvien[index]; }
        set { danhsachsinhvien[index] = value; }
    }
    public void ThemSV(Student sv)
    {
        danhsachsinhvien.Add(sv);
    }

    public void GhiFile()
    {
        string filename = "Danhsach.txt";

        StreamWriter sw = new StreamWriter(new FileStream(filename,FileMode.Create,FileAccess.Write));
        foreach (Student item in danhsachsinhvien)
        {
            string mssv = item.Mssv;
            string hotenlot = item.Hotenlot;
            string ten = item.Ten;
            string gioitinh = "Nữ";
            if (item.Gioitinh)
                gioitinh = "Nam";
            string ngaysinh = item.Ngaysinh.ToString("m/D/yyyy");
            string lop = item.Lop;
            string cmnd = item.Cmnd;
            string sodt = item.Sodt;
            string diachi = item.Diachi;
            string mhdk = "";
            foreach (string mh in item.Monhocdangky)
            {
                mhdk += mh + ",";
            }
            mhdk = mhdk.Substring(0, mhdk.Length - 1);//?
            string student = mssv + "*" + hotenlot + "*" + ten + "*" + gioitinh + "*" + ngaysinh + "*" + lop + "*" + cmnd + "*" + sodt + "*" +
                diachi + "*" + mhdk;
            sw.WriteLine(student);

        }
        sw.Close();

    }

    public void DocFile()
    {
        string filename = "Danhsach.txt",t;
        string[] s;
        Student sv;
        StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
        while ((t =sr.ReadLine()) != null) 
        {
            s = t.Split('*');
            sv = new Student();
            sv.Mssv = s[0];
            sv.Hotenlot = s[1];
            sv.Ten = s[2];
            bool gioitinh = false;
            if (s[3] == "Nam")
                gioitinh = true;
            sv.Gioitinh = gioitinh;
            sv.Ngaysinh = DateTime.ParseExact(s[4], "M/d/yyyy", CultureInfo.InvariantCulture);
            sv.Lop = s[5];
            sv.Cmnd = s[6];
            sv.Sodt = s[7];
            sv.Diachi = s[8];
            string[] mhdk = s[9].Split(',');
            foreach (string item in mhdk)
            {
                sv.Monhocdangky.Add(item);
            }
            ThemSV(sv);
        }
        sr.Close();
    }

}
