using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EMRge.Entities
{
    public class LaboratoryTestRecord
    {
        public string ID { get; set; }
        public string ExaminationRecordID { get; set; }
        public DateTime DateAndTime { get; set; }
        public string PatientID { get; set; }
        public string LabPhysicianID { get; set; }
        public string TestType { get; set; }
        public string Result { get; set; }
        public bool IsRemovedFromQueue { get; set; } = false;

        public void Insert()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "EXEC InsertLaboratoryRecord " +
                        "@ID OUTPUT, " +
                        "@ExaminationRecordID, " +
                        "@DateAndTime, " +
                        "@PatientID, " +
                        "@LabPhysicianID, " +
                        "@TestType, " +
                        "@Result, " +
                        "@IsRemovedFromQueue";

                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.Add("@ID", System.Data.SqlDbType.VarChar, 50);
                    cmd.Parameters["@ID"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@ExaminationRecordID", this.ExaminationRecordID);
                    cmd.Parameters.AddWithValue("@DateAndTime", this.DateAndTime);
                    cmd.Parameters.AddWithValue("@PatientID", this.PatientID);
                    cmd.Parameters.AddWithValue("@LabPhysicianID", this.LabPhysicianID);
                    cmd.Parameters.AddWithValue("@TestType", this.TestType);
                    cmd.Parameters.AddWithValue("@Result", this.Result);
                    cmd.Parameters.AddWithValue("@IsRemovedFromQueue", Convert.ToInt32(this.IsRemovedFromQueue));

                    cmd.ExecuteNonQuery();
                    this.ID = Convert.ToString(cmd.Parameters["@ID"].Value);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static List<LaboratoryTestRecord> GetLaboratoryTestRecords()
        {
            List<LaboratoryTestRecord> records = new List<LaboratoryTestRecord>();

            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                string query = "SELECT * FROM LaboratoryTestRecord ORDER BY DateAndTime";
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LaboratoryTestRecord record = new LaboratoryTestRecord()
                    {
                        ID = reader["ID"].ToString(),
                        ExaminationRecordID = reader["ExaminationRecordID"].ToString(),
                        DateAndTime = DateTime.Parse(reader["DateAndTime"].ToString()),
                        PatientID = reader["PatientID"].ToString(),
                        LabPhysicianID = reader["LabPhysicianID"].ToString(),
                        TestType = reader["TestType"].ToString(),
                        Result = reader["Result"].ToString(),
                        IsRemovedFromQueue = Convert.ToBoolean(reader["IsRemovedFromQueue"])
                    };
                    records.Add(record);
                }
            }
            return records;
        }

    }
}
