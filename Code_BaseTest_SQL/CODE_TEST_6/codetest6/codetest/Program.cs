using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ADO
{
    //Using Ado.net classes/methods, insert employee record in the table by invoking the procedure



    class Program
    {

        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlCommand cmd;
        static SqlConnection Makeconnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-HB33YS3;Initial Catalog=Assignment2;" +
                "integrated Security=true");
            con.Open();
            return con;
        }

        static void DataSelect()
        {
            con = Makeconnection();
            cmd = new SqlCommand("Select *from Code_employee", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Empno:" + dr[0]);
                Console.WriteLine("Empname:" + dr[1]);
                Console.WriteLine("Empsalary:" + dr[2]);
                Console.WriteLine("Emptype:" + dr[3]);
            }
        }
        static void Insertion()
        {
            con = Makeconnection();
            try
            {
                int empno;
                string empname;
                float empsal;
                string emptype;
                Console.WriteLine("Enter empno,empname,salary,emptype:");
                empno = Convert.ToInt32(Console.ReadLine());
                empname = Console.ReadLine();
                empsal = Convert.ToSingle(Console.ReadLine());
                emptype = Console.ReadLine();
                cmd = new SqlCommand("insert into Code_employee values(@empno,@empname,@empsal,@emptype)", con);
                cmd.Parameters.AddWithValue("@empno", empno);
                cmd.Parameters.AddWithValue("@empname", empname);
                cmd.Parameters.AddWithValue("@empsal", empsal);
                cmd.Parameters.AddWithValue("@emptype", emptype);
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
            Display();

            Console.ReadLine();
        }
        static void Display()
        {
            con = Makeconnection();
            cmd = new SqlCommand("SELECT * FROM Code_employee", con);

            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("Employee Records:");
            while (dr.Read())

            {

                Console.WriteLine($"Employee ID: {dr["empno"]}, Name: {dr["empname"]}, Salary: {dr["empsal"]}, Type: {dr["emptype"]}");

            }

        }





        static void Main()
        {
            DataSelect();
            Insertion();
            Console.Read();
        }
    }

}