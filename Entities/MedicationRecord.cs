using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EMRge.Entities
{
    public class MedicationRecord
    {
        public string ID { get; set; }
        public string ExaminationRecordID { get; set; }
        public string Medication { get; set; }
        public string AlternativeMedication { get; set; }

        public void Insert()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "EXEC InsertMedicationRecord " +
                        "@ID OUTPUT, " +
                        "@ExaminationRecordID, " +
                        "@Medication, " +
                        "@AlternativeMedication";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.Add("@ID", System.Data.SqlDbType.VarChar, 50);
                    cmd.Parameters["@ID"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@ExaminationRecordID", this.ExaminationRecordID);
                    cmd.Parameters.AddWithValue("@Medication", this.Medication);
                    cmd.Parameters.AddWithValue("@AlternativeMedication", this.AlternativeMedication);

                    cmd.ExecuteNonQuery();
                    this.ID = Convert.ToString(cmd.Parameters["@ID"].Value);
                    MessageBox.Show("Medication record added successfully!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static List<MedicationRecord> GetMedicationRecords()
        {
            List<MedicationRecord> records = new List<MedicationRecord>();

            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                string query = "SELECT * FROM MedicationRecord";
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MedicationRecord record = new MedicationRecord()
                    {
                        ID = reader["ID"].ToString(),
                        ExaminationRecordID = reader["ExaminationRecordID"].ToString(),
                        Medication = reader["Medication"].ToString(),
                        AlternativeMedication = reader["AlternativeMedication"].ToString()
                    };
                    records.Add(record);
                }
            }
            return records;
        }

    }
}
