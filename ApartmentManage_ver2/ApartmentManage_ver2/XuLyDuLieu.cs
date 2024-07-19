using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ApartmentManage_ver2
{
    class XuLyDuLieu
    {

        public SqlConnection con;
        public XuLyDuLieu()
        {
            con = new SqlConnection();

            con.ConnectionString = @"Data Source=LAPTOP-C7PJQHA5;Initial Catalog=quanlychungcu;Integrated Security=True";
        }

        public void moKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public void dongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public DataTable bangDuLieu(String SQL)
        {
            DataTable tb = new DataTable();
            this.moKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, this.con);
            adp.Fill(tb);
            this.dongKetNoi();
            return tb;
        }

        public bool thucThiSQL(String SQL)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandText = SQL;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                this.dongKetNoi();
            }
            return false;
        }

        public object thucThiGiaTriDon(String SQL)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandText = SQL;

                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                this.dongKetNoi();
            }
            return null;
        }

        public DataTable bangDuLieuThuTuc(String nameProcedure, SqlParameter[] pr)
        {
            DataTable tb = new DataTable();
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProcedure;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(tb);
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                this.dongKetNoi();
            }
            return tb;
        }

        public bool thucThiThuTuc(String nameProcedure, SqlParameter[] pr)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProcedure;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                    //cmd.Parameters.Clear();
                if (cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                this.dongKetNoi();
            }
            return false;
        }

        public object thucThiGiaTriDonThuTuc(String nameProcedure, SqlParameter[] pr)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProcedure;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                this.dongKetNoi();
            }
            return null;
        }

        public DataSet bangDuLieuDS(String NameProcedure, SqlParameter[] pr)
        {
            DataSet ds = new DataSet();
            try
            {
                moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = NameProcedure;
                cmd.Connection = this.con;
                if (pr != null)
                    cmd.Parameters.AddRange(pr);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                dongKetNoi();
            }
            return ds;
        }
    }
}
