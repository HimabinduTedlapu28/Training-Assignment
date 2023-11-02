using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace codebased6
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source= ICS-LT-CZFBR73;Initial Catalog=Code_Employes; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("insert Code_Employes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    Console.Write("Employee Name: ");
                    string empname = Console.ReadLine();

                    Console.Write("Employee Salary: ");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Employment Type (F for full-time, P for part-time): ");
                    string emptype = Console.ReadLine();
                    if (emptype != "F" && emptype != "P")
                    {
                        Console.WriteLine("Invalid employment type input.");
                        return;
                    }
                    cmd.Parameters.Add(new SqlParameter("@empname", empname));
                    cmd.Parameters.Add(new SqlParameter("@salary", salary));
                    cmd.Parameters.Add(new SqlParameter("@emptype", emptype));
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Employee Added");
                Displaydata(con);
                Console.ReadLine();
            }
        }

        static void Displaydata(SqlConnection con)
        {
            Console.WriteLine("emp table :");
            using (SqlCommand selectCommand = new SqlCommand("SELECT * FROM Code_Employes", con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
            {
                DataTable employeesTable = new DataTable();
                adapter.Fill(employeesTable);
                foreach (DataRow row in employeesTable.Rows)
                {
                    Console.WriteLine($"EmployeeID-->{row["empno"]}\t  |   Name-->{row["empname"]}  \t   |  Salary-->{row["salary"]} \t   |  Type-->{row["emptype"]}");
                }
            }
        }
    }
}