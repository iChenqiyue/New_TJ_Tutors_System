using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_TJ_Tutors_System
{
    public class objectclass
    {
        public class tutorinfo
        {
            public string tutor_num, name, student_num, subject, degree, sex, phone, place, blacklist, explantion, remarks;
            public void reset()
            {
                init();
            }
            public void truck()
            {
                init();
            }
            private void init()
            {
                tutor_num = "";
                name = "";
                student_num = "";
                subject = "";
                degree = "";
                sex = "";
                phone = "";
                place = "";
                blacklist = "";
                explantion = "";
                remarks = "";
            }
            
        }
        public class tutoringinfo
        {
            public string parent_num, print_num, reception, reception_time, parent_name, phone, simple_adr, detail_adr,
        grade_stu, subject_stu, student_sex, tutors_price, tutors_time, sex, place, grade, subject, other_requests,
        payment_state, payment_time, tutor_state, remarks, latest_time;
            public int count = 23;
            public void truck()
            {
                init();
            }
            public void reset()
            {
                init();
            }
            private void init()
            {
                parent_num = "";
                print_num = "";
                reception = "";
                reception_time = "";
                parent_name = "";
                phone = "";
                simple_adr = "";
                detail_adr = "";
                grade_stu = "";
                subject_stu = "";
                student_sex = "";
                tutors_price = "";
                tutors_time = "";
                sex = "";
                place = "";
                grade = "";
                subject = "";
                other_requests = "";
                payment_state = "";
                payment_time = "";
                tutor_state = "";
                remarks = "";
                latest_time = "";
            }
            public string connectstr()
            {
                string str = "('" + parent_num + "','" + print_num + "','" + reception + "','" + reception_time + "','" + parent_name + "','" + phone
                    + "','" + simple_adr + "','" + detail_adr + "','" + grade_stu + "','" + subject_stu + "','" + student_sex + "','" + tutors_price
                    + "','" + tutors_time + "','" + sex + "','" + place + "','" + grade + "','" + subject + "','" + other_requests + "','"
                    + payment_state + "','" + tutor_state + "','" + remarks + "','" + latest_time + "')";
                return str;
            }
            public string updatestr()
            {
                string mysql = string.Format("UPDATE tutoring SET parent_num='{0}',reception='{1}',reception_time='{2}',parent_name='{3}'," +
                            "phone='{4}',simple_adr='{5}',detail_adr='{6}',grade_stu='{7}',subject_stu='{8}',student_sex='{9}'," +
                            "tutor_price='{10}',tutor_time='{11}',sex='{12}',place='{13}',grade='{14}',subject='{15}',other_request='{16}'," +
                            "payment_state='{17}',latest_time='{18}' WHERE print_num='{19}'", parent_num, reception, reception_time,
                            parent_name, phone, simple_adr, detail_adr, grade_stu, subject_stu, student_sex, tutors_price, tutors_time, sex,
                            place, grade, subject, other_requests, payment_state, latest_time, print_num);
                return mysql;
            }
        }
        
    }
}
