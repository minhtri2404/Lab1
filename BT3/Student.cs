using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Student : People
    {
        private int SID;
        private string Khoa;
        private float DiemTB;

        public Student() //Default constructor
        {
            SID = 1;
            Name = "Ho Minh Tri";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student st) //Copy constructor
        {
            SID = st.SID;
            Name = st.Name;
            Khoa = st.Khoa;
            DiemTB = st.DiemTB;
        }

        //Constructor with parameters
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            Name = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public int GetStudentId() => SID;
        public void SetStudentId(int value) => SID = value;

        public string GetFaculty() => Khoa;
        public void SetFaculty(string value) => Khoa = value;

        public float GetMark() => DiemTB;
        public void SetMark(float value) => DiemTB = value;

        public void Show()
        {
            Console.WriteLine("SID: " + GetStudentId());
            Console.WriteLine("Ho và ten: " + Name);
            Console.WriteLine("Khoa: " + GetFaculty());
            Console.WriteLine("Diem trung binh: " + GetMark());
        }

    }

}
