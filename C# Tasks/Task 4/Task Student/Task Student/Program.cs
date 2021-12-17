using System;

namespace Task_Student
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Student
        {
            public string fullname;
            public string cource;
            public string subject;
            public string university;
            public string e_mail;
            public string phone;
            public Student(){}
            public Student(string name, string surname)
            {
                fullname = name + " " + surname;
            }
            public Student(string name, string surname, string cource, string subject, string university, string e_mail, string phone)
            {
                this.fullname = name + " " + surname;
                this.cource = cource;
                this.subject = subject;
                this.university = university;
                this.e_mail = e_mail;
                this.phone = phone;
            }
            public Student(string fullname, string cource, string subject, string university, string e_mail, string phone)
            {
                this.fullname = fullname;
                this.cource = cource;
                this.subject = subject;
                this.university = university;
                this.e_mail = e_mail;
                this.phone = phone;
            }

            public string Info()
            {
                return $"I'am {fullname} and I'am {cource} cource and studing in {university},{subject}.\nMy Phone : {phone}\nMy E-Mail : {e_mail}";
            }

        }
    }
}
