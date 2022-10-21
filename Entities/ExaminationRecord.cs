using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EMRge.Entities
{
    public class ExaminationRecord
    {
        public string ID { get; set; }
        public DateTime DateAndTime { get; set; }
        public string PatientID { get; set; }
        public string PhysicianID { get; set; }
        public string Diagnosis { get; set; }
        public bool IsRemovedFromQueue { get; set; } = false;

        public void Insert()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "EXEC InsertExaminationRecord " +
                        "@ID OUTPUT, " +
                        "@DateAndTime, " +
                        "@PatientID, " +
                        "@PhysicianID, " +
                        "@Diagnosis, " +
                        "@IsRemovedFromQueue";

                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.Add("@ID", System.Data.SqlDbType.VarChar, 50);
                    cmd.Parameters["@ID"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@DateAndTime", this.DateAndTime);
                    cmd.Parameters.AddWithValue("@PatientID", this.PatientID);
                    cmd.Parameters.AddWithValue("@PhysicianID", this.PhysicianID);
                    cmd.Parameters.AddWithValue("@Diagnosis", " ");
                    cmd.Parameters.AddWithValue("@IsRemovedFromQueue", Convert.ToInt32(this.IsRemovedFromQueue));

                    cmd.ExecuteNonQuery();
                    this.ID = Convert.ToString(cmd.Parameters["@ID"].Value);
                    MessageBox.Show("Examination record added successfully!");
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static List<ExaminationRecord> GetExaminationRecords()
        {
            List<ExaminationRecord> records = new List<ExaminationRecord>();

            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                string query = "SELECT * FROM ExaminationRecord WHERE IsRemovedFromQueue = 0 ORDER BY DateAndTime";
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ExaminationRecord record = new ExaminationRecord()
                    {
                        ID = reader["ID"].ToString(),
                        DateAndTime = DateTime.Parse(reader["DateAndTime"].ToString()),
                        PatientID = reader["PatientID"].ToString(),
                        PhysicianID = reader["PhysicianID"].ToString(),
                        Diagnosis = reader["Diagnosis"].ToString()
                    };
                    records.Add(record);
                }
            }
            return records;
        }

    }
}
