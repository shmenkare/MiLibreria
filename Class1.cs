using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string sql)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");

            Con.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter Da = new SqlDataAdapter(sql, Con);

            Da.Fill(ds);

            Con.Close();

            return ds;
        }

    }
}
