using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string sql)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            
            Con.Open();

            DataSet Ds = new DataSet();

            SqlDataAdapter Da = new SqlDataAdapter(sql, Con);

            Da.Fill(Ds);

            Con.Close();

            return Ds;
         }
        
       
        

    }
}
