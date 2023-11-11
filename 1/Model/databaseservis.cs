using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Model
{
    public class databaseservis
    {
        private string connectionString = "";

        public void SaveLoanRequest(zahtevzazajam request)
        {
            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "";
                    using (Sqlkomanda komanda = new Sqlkomanda(query, connection))
                    {
                        komanda.Parameters.AddWithValue("@KorisnikID", request.KorisnikId);
                        komanda.Parameters.AddWithValue("@TrazenaSuma", request.TrazenaSuma);
                        komanda.ExecuteNonQuery();
                    }

                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Error: ",ex.Message);
                }
            }
        }
    }
}
