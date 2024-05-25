using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student() //Constructor mac dinh (default constructor)
        {
            SID = 1;
            TenSV = "Ho Minh Tri";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student st) //Copy constructor
        {
            SID = st.SID;
            TenSV = st.TenSV;
            Khoa = st.Khoa;
            DiemTB = st.DiemTB;
        }

        //Constructor with parameters
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        //Properties for each attribute of the class
        public int StudentID
        {
            get { return SID; } //Get data
            set { SID = value; } //Set data
        }

        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }

        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }

        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        public void Show()
        {
            Console.WriteLine("SID: " + SID);
            Console.WriteLine("Ho và ten: " + Name);
            Console.WriteLine("Khoa: " + Faculty);
            Console.WriteLine("Diem trung binh: " + Mark);
        }

    }
}
