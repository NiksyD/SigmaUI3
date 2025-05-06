using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Pepito_Appsdev_Finals.Models;

namespace Pepito_Appsdev_Finals.Repository
{
    public class RepositorySubjectSched
    {
        public readonly string _connectionString = "Data Source=NIKOY\\SQLEXPRESS;Initial Catalog=AppsdevEnrollment;Integrated Security=True;Trust Server Certificate=True";

        public bool AddSubjectSched(SubjectSchedFile subjectSchedFile)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO SubjectSchedFile 
                (SSFEDPCODE, SSFSUBJCODE, SSFSTARTTIME, SSFENDTIME, SSFDAYS, SSFROOM, 
                 SSFMAXSIZE, SSFCLASSSIZE, SSFSTATUS, SSFXM, SSFSECTION, SSFSCHOOLYEAR) 
                 VALUES (@SSFEDPCODE, @SSFSUBJCODE, @SSFSTARTTIME, @SSFENDTIME, @SSFDAYS, 
                         @SSFROOM, @SSFMAXSIZE, @SSFCLASSSIZE, @SSFSTATUS, @SSFXM, @SSFSECTION, @SSFSCHOOLYEAR)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SSFEDPCODE", subjectSchedFile.SSFEDPCODE);
                cmd.Parameters.AddWithValue("@SSFSUBJCODE", subjectSchedFile.SSFSUBJCODE);
                cmd.Parameters.AddWithValue("@SSFSTARTTIME", subjectSchedFile.SSFSTARTTIME);
                cmd.Parameters.AddWithValue("@SSFENDTIME", subjectSchedFile.SSFENDTIME);
                cmd.Parameters.AddWithValue("@SSFDAYS", subjectSchedFile.SSFDAYS);
                cmd.Parameters.AddWithValue("@SSFROOM", subjectSchedFile.SSFROOM);
                cmd.Parameters.AddWithValue("@SSFMAXSIZE", subjectSchedFile.SSFMAXSIZE);
                cmd.Parameters.AddWithValue("@SSFCLASSSIZE", subjectSchedFile.SSFCLASSSIZE);
                cmd.Parameters.AddWithValue("@SSFSTATUS", subjectSchedFile.SSFSTATUS);
                cmd.Parameters.AddWithValue("@SSFXM", subjectSchedFile.SSFXM);
                cmd.Parameters.AddWithValue("@SSFSECTION", subjectSchedFile.SSFSECTION);
                cmd.Parameters.AddWithValue("@SSFSCHOOLYEAR", subjectSchedFile.SSFSCHOOLYEAR);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateSubjectSched(SubjectSchedFile subjectSchedFile)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE SubjectSchedFile SET 
                        SSFSUBJCODE = @SSFSUBJCODE, 
                        SSFSTARTTIME = @SSFSTARTTIME, 
                        SSFENDTIME = @SSFENDTIME, 
                        SSFDAYS = @SSFDAYS, 
                        SSFROOM = @SSFROOM, 
                        SSFMAXSIZE = @SSFMAXSIZE, 
                        SSFCLASSSIZE = @SSFCLASSSIZE, 
                        SSFSTATUS = @SSFSTATUS, 
                        SSFXM = @SSFXM, 
                        SSFSECTION = @SSFSECTION, 
                        SSFSCHOOLYEAR = @SSFSCHOOLYEAR 
                        WHERE SSFEDPCODE = @SSFEDPCODE";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SSFEDPCODE", subjectSchedFile.SSFEDPCODE);
                cmd.Parameters.AddWithValue("@SSFSUBJCODE", subjectSchedFile.SSFSUBJCODE);
                cmd.Parameters.AddWithValue("@SSFSTARTTIME", subjectSchedFile.SSFSTARTTIME);
                cmd.Parameters.AddWithValue("@SSFENDTIME", subjectSchedFile.SSFENDTIME);
                cmd.Parameters.AddWithValue("@SSFDAYS", subjectSchedFile.SSFDAYS);
                cmd.Parameters.AddWithValue("@SSFROOM", subjectSchedFile.SSFROOM);
                cmd.Parameters.AddWithValue("@SSFMAXSIZE", subjectSchedFile.SSFMAXSIZE);
                cmd.Parameters.AddWithValue("@SSFCLASSSIZE", subjectSchedFile.SSFCLASSSIZE);
                cmd.Parameters.AddWithValue("@SSFSTATUS", subjectSchedFile.SSFSTATUS);
                cmd.Parameters.AddWithValue("@SSFXM", subjectSchedFile.SSFXM);
                cmd.Parameters.AddWithValue("@SSFSECTION", subjectSchedFile.SSFSECTION);
                cmd.Parameters.AddWithValue("@SSFSCHOOLYEAR", subjectSchedFile.SSFSCHOOLYEAR);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public bool DeleteSubjectSched(string edpCode)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM SubjectSchedFile WHERE SSFEDPCODE = @SSFEDPCODE";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SSFEDPCODE", edpCode);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0; // Returns true if at least one row is deleted
                }
            }
        }

        //  Dispay subjects in a DataTable
        public DataTable GetSubjectsSched()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = @"
                        SELECT ss.*, sf.SFSUBJUNITS, sf.SFSUBJDESC 
                        FROM SubjectSchedFile ss
                        LEFT JOIN SubjectFile sf ON ss.SSFSUBJCODE = sf.SFSUBJCODE";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return dt;
        }

        public bool IsSubjectSchedExists(string edpCode)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT COUNT(*) FROM SubjectSchedFile WHERE SSFEDPCODE = @SSFEDPCODE";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SSFEDPCODE", edpCode);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
