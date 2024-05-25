using System;

namespace BT2
{
    internal class Student
    {
        private int SID;
        private string Khoa;
        private string TenSV;
        private float DiemTB;

        public Student() // Default constructor
        {
            SID = 1;
            TenSV = "Ho Minh Tri";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student st) // Copy constructor
        {
            SID = st.SID;
            TenSV = st.TenSV;
            Khoa = st.Khoa;
            DiemTB = st.DiemTB;
        }

        // Constructor with parameters
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public int GetStudentId() => SID;
        public void SetStudentId(int value) => SID = value;

        public string GetName() => TenSV;
        public void SetName(string value) => TenSV = value;

        public string GetFaculty() => Khoa;
        public void SetFaculty(string value) => Khoa = value;

        public float GetMark() => DiemTB;
        public void SetMark(float value) => DiemTB = value;

        public void Show()
        {
            Console.WriteLine("SID: " + GetStudentId());
            Console.WriteLine("Ho va ten: " + GetName());
            Console.WriteLine("Khoa: " + GetFaculty());
            Console.WriteLine("Diem trung binh: " + GetMark());
        }
    }
}
