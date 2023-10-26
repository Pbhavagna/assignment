using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace connection
{
    public class student
    {
        public int si { get; set; }
        public string sname { get; set; }
        public string sdob { get; set; }
    }
    public class course
    {
        public int cid { get; set; }
        public string cname { get; set; }
    }
    public class Enroll
    {
        public student Student { get; set; }
        public course Course { get; set; }
        public string EnrollmentDate { get; set; }
    }
    class Program
    {
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlCommand cmd;
        static SqlConnection Makeconnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-HB33YS3;Initial Catalog=CaseStudy;" +
                "integrated Security=true");
            con.Open();
            return con;
        }
        static void DataSelectStudent()
        {
            con = Makeconnection();
            cmd = new SqlCommand("Select*from student", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("student id:" + dr[0]);
                Console.WriteLine("Student name:" + dr[1]);
                Console.WriteLine("Student dob:" + dr[2]);
            }
        }
        static void DataSelectCourse()
        {
            con = Makeconnection();
            cmd = new SqlCommand("Select *from course", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("course id:" + dr[0]);
                Console.WriteLine("course name:" + dr[1]);
            }
        }
        static void DataSelectEnroll()
        {
            con = Makeconnection();
            cmd = new SqlCommand("Select*from Enroll", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("student id:" + dr[0]);
                Console.WriteLine("course id:" + dr[1]);
                Console.WriteLine("Student name:" + dr[2]);
                Console.WriteLine("Student dob:" + dr[3]);
                Console.WriteLine("course name:" + dr[4]);
                Console.WriteLine("Enrollment date:" + dr[5]);

            }
        }
        static void InsertionStudent()
        {
            con = Makeconnection();
            try
            {
                int sid;
                string sname;
                string sdob;
                Console.WriteLine("Enter sid,sname,sdob:");
                sid = Convert.ToInt32(Console.ReadLine());
                sname = Console.ReadLine();
                sdob = Console.ReadLine();
                cmd = new SqlCommand("insert into student values(@sid,@sname,@sdob)", con);
                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@sdob", sdob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data got Inserted");
                else
                    Console.WriteLine("Error Occured");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        static void InsertionCourse()
        {
            con = Makeconnection();
            try
            {
                int cid;
                string cname;
                Console.WriteLine("Enter cid,cname:");
                cid = Convert.ToInt32(Console.ReadLine());
                cname = Console.ReadLine();
                cmd = new SqlCommand("insert into course values(@cid,@cname)", con);
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@cname", cname);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("data inserted");
                else
                    Console.WriteLine("error occured");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        static void InsertionEnroll()
        {
            con = Makeconnection();
            try
            {
                int sid;
                int cid;
                string sname;
                string sdob;
                string cname;
                string enrolldate;
                Console.WriteLine("Enter sid,cid,sname,sdob,cname,enrolldate:");
                sid = Convert.ToInt32(Console.ReadLine());
                cid = Convert.ToInt32(Console.ReadLine());
                sname = Console.ReadLine();
                sdob = Console.ReadLine();
                cname = Console.ReadLine();
                enrolldate = Console.ReadLine();
                cmd = new SqlCommand("insert into enroll values(@sid,@cid,@sname,@sdob,@cname,@enrolldate)", con);
                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@sdob", sdob);
                cmd.Parameters.AddWithValue("@cname", cname);
                cmd.Parameters.AddWithValue("@enrolldate", enrolldate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Data got Inserted");
                else
                    Console.WriteLine("Error Occured");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        public static void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS (Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Exit");
            Console.Write("Enter your choice (1, 2, or 3): ");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting the program, Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    ShowFirstScreen();
                    break;
            }
        }
        public static void ShowStudentScreen()
        {
            Console.WriteLine("Student Menu:");
            Console.WriteLine("1. View All Courses");
            Console.WriteLine("2. Register for a Course");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowAllCoursesScreen();
                    break;
                case 2:
                    ShowStudentRegistrationScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting Student Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                    ShowStudentScreen();
                    break;
            }
        }
        public static void ShowAdminScreen()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Introduce New Course");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    IntroduceNewCourseScreen();
                    break;
                case 2:
                    ShowAllStudentsScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting Admin Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                    ShowAdminScreen();
                    break;
            }
        }
        public static void ShowAllStudentsScreen()
        {
            Console.WriteLine("List of Students:");
            DataSelectStudent();
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowAdminScreen();
        }
        public static void ShowStudentRegistrationScreen()
        {
            InsertionStudent();
            InsertionEnroll();
            Console.WriteLine("Student registered successfully.");
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowStudentScreen();
        }
        public static void IntroduceNewCourseScreen()
        {
            InsertionCourse();
            Console.WriteLine("Course introduced successfully.");
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowAdminScreen();
        }
        public static void ShowAllCoursesScreen()
        {
            Console.WriteLine("List of Courses:");
            DataSelectCourse();
            Console.WriteLine("Press Enter to return to the previous menu...");
            Console.ReadLine();
            ShowStudentScreen();
        }
        static void Main()
        {
            ShowFirstScreen();
            Console.Read();
        }
    }
}