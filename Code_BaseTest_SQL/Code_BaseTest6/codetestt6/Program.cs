using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace codetestt6
{
    class Program
    {
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlCommand cmd;
        static SqlConnection Getconnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-HB33YS3;Initial Catalog=Assignment2;" +
                "integrated Security=true");
            con.Open();
            return con;
        }
        static void Insertdata()
        {
            con = Getconnection();
            Console.WriteLine("Enter employee name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter employee salary: ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter employee type(F or P): ");
            string empType = Console.ReadLine();
            cmd = new SqlCommand("AddEmployee", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@empname", empName));
            cmd.Parameters.Add(new SqlParameter("@empsal", empSal));
            cmd.Parameters.Add(new SqlParameter("@emptype", empType));
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                Console.WriteLine("Record  got Inserted");
            else
                Console.WriteLine("Not Inserted");
        }

        static void SelectData()
        {
            con = Getconnection();
            cmd = new SqlCommand("select * from Code_Employee", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"Employee Number: {dr["empno"]}, Name: {dr["empname"]}, Salary:{dr["empsal"]}, Type:{dr["emptype"]}");
            }
        }
        static void Main()
        {
            Insertdata();
            SelectData();
            Console.ReadLine();
        }
    }

}
