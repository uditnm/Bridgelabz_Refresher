using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class ReadRecords
    {
        public void read(string constring)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(constring);
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "spReadRecords";

                con.Open();
                SqlDataReader sdr = comm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"] + " " + sdr["salary"]);
                }
                Console.WriteLine("Successfull");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
