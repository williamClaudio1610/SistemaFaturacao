using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
	internal class TaxasIVA
	{

		public List<decimal> ObterTaxasIVA()
		{
			List<decimal> valoresIVA = new List<decimal>();
			string connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					string query = "SELECT Taxa FROM TaxasIVA";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								valoresIVA.Add(Convert.ToDecimal(reader["Taxa"]));
							}
						}
					}
				}
				catch (Exception ex)
				{
					return null;
				}
			}

			return valoresIVA;
		}


	}
}
