using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

namespace Clinica_Frba.ConnectorSQL
{
    class ConnectorClass
    {

        static ConnectorClass instance = null;

        private SqlConnection conn;
        private SqlConnection Conn
        {
            get { return this.conn; }
            set { this.conn = value; }
        }

        private string error;
        public string Error
        {
            get { return this.error; }
            set { this.error = value; }
        }

        private ConnectorClass()
        {
            string strConn = getConnectionString();
            try
            {   
                this.Conn = new SqlConnection(strConn);
                this.Conn.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: No se pudo conectar, error:       " + e.StackTrace);
            }
            
        }

        public static ConnectorClass Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConnectorClass();
                return instance;
            }
        }

        public DataTable executeQuery(string query)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandTimeout = 999999999;

            sqlCommand.Connection = this.Conn;
            sqlCommand.CommandText = query;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.Conn);

            DataTable dataTable = new DataTable();
            dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;


            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void executeQueryOnly(string query)
        {
            SqlCommand com = new SqlCommand();
            com.CommandTimeout = 999999999;

            com.Connection = this.Conn;
            com.CommandText = query;
            com.ExecuteNonQuery();
            com.Dispose();
            com = null;
        }

        public void CloseConnection()
        {
            this.conn.Close();
        }

        public static String ParseDateTime(DateTime time)
        {
            return (time.Year * 10000 + time.Month * 100 + time.Day).ToString();
        }

        public static DateTime getFechaSistema()
        {
            return Convert.ToDateTime(ConfigurationSettings.AppSettings["fechaSistema"]);
        }

        public string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }
    
    }
}