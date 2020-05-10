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
            public string connectstr()
            {
                string str = "('" + tutor_num + "','" + name + "','" + student_num + "','" + subject + "','" + degree + "','" + sex
                    + "','" + phone + "','" + place + "','" + blacklist + "','" + explantion + "','" + remarks + "')";
                return str;
            }
            public string updatestr()
            {
                string mysql = string.Format("UPDATE tutor SET name='{0}',student_num='{1}',subject='{2}',degree='{3}'," +
                            "sex='{4}',phone='{5}',place='{6}',blacklist='{7}',explanation='{8}',remarks='{9}' WHERE tutor_num='{10}'",
                            name, student_num, subject, degree, sex, phone, place, blacklist, explantion, remarks, tutor_num);
                return mysql;
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

        public class business
        {
            public string print_num, tutor_num, tutor_name, subject, state, time, reception, remarks, now;
            public string connectstr()
            {
                string str = "('" + print_num + "','" + tutor_num + "','" + tutor_name + "','" + subject + "','" + state + "','" + time
                    + "','" + reception + "','" + remarks + "','" + now + "')";
                return str;
            }
        }

        public class workerinfo
        {
            public string worker_num, name, sex, student_num, subject, phone, position, month_score, total_score,isleave;

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
                worker_num="";
                name ="";
                sex ="";
                student_num ="";
                subject ="";
                phone ="";
                position ="";
                month_score ="";
                total_score = "";
                isleave = "";
            }

            public string connectstr()
            {
                string str = "('" + worker_num + "','" + name + "','" + sex+"','"+student_num + "','" + subject + "','"  + phone + "','" + 
                    position + "','" + month_score + "','" + total_score + "','" + isleave + "')";
                return str;
            }
            public string updatestr()
            {
                string mysql = string.Format("UPDATE worker SET name='{0}',student_num='{1}',subject='{2}'," +
                            "sex='{3}',phone='{4}',position='{5}',isleave='{6}',month_score='{7}',total_score='{8}' WHERE worker_num='{9}'",
                            name, student_num, subject, sex, phone, position, isleave, month_score, total_score, worker_num);
                return mysql;
            }
        }
        public static class userinfo
        {
            public static string username, password, degree;
        }
    }
}
