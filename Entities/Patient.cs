using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EMRge.Entities
{
    public class Patient
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public DateTime DateRegistered { get; set; }
        public string BranchRegistered { get; set; }
        public bool IsInPatient { get; set; }
        public string RoomNumber { get; set; }

        // Emergency Contact Info
        public string ECName { get; set; }
        public string ECRelation { get; set; }
        public string ECPhoneNumber { get; set; }
        public string ECEmail { get; set; }


        // Health Information
        public string BloodType { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        // --
        public bool IsDeleted { get; set; } = false;

        public static List<Patient> GetAllInPatients() {
            List<Patient> list = new List<Patient>();
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "EXEC GetAllInPatients";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Patient patient = new Patient()
                        {
                            ID = reader["ID"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Address = reader["Address"].ToString(),
                            Nationality = reader["Nationality"].ToString(),
                            DateRegistered = DateTime.Parse(reader["DateRegistered"].ToString()),
                            BranchRegistered = reader["BranchRegistered"].ToString(),
                            IsInPatient = Convert.ToBoolean(reader["IsInPatient"]),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            //
                            ECName = reader["ECName"].ToString(),
                            ECRelation = reader["ECRelation"].ToString(),
                            ECPhoneNumber = reader["ECPhoneNumber"].ToString(),
                            ECEmail = reader["ECEmail"].ToString(),
                            //
                            BloodType = reader["BloodType"].ToString(),
                            Height = float.Parse(reader["Height"].ToString()),
                            Weight = float.Parse(reader["Weight"].ToString())
                        };
                        list.Add(patient);
                    }

                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

            return list;
        }

        public static List<Patient> GetAllOutPatients()
        {
            List<Patient> list = new List<Patient>();
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {

                    string query = "EXEC GetAllOutPatients";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Patient patient = new Patient()
                        {
                            ID = reader["ID"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Address = reader["Address"].ToString(),
                            Nationality = reader["Nationality"].ToString(),
                            DateRegistered = DateTime.Parse(reader["DateRegistered"].ToString()),
                            BranchRegistered = reader["BranchRegistered"].ToString(),
                            IsInPatient = Convert.ToBoolean(reader["IsInPatient"]),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            //
                            ECName = reader["ECName"].ToString(),
                            ECRelation = reader["ECRelation"].ToString(),
                            ECPhoneNumber = reader["ECPhoneNumber"].ToString(),
                            ECEmail = reader["ECEmail"].ToString(),
                            //
                            BloodType = reader["BloodType"].ToString(),
                            Height = float.Parse(reader["Height"].ToString()),
                            Weight = float.Parse(reader["Weight"].ToString())
                        };
                        list.Add(patient);
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return list;
        }

        public static string GeneratePatientID()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    conn.Open();
                    string query = "EXEC GeneratePatientID @ID OUTPUT";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@ID", System.Data.SqlDbType.VarChar, 50);
                    cmd.Parameters["@ID"].Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    string ID = Convert.ToString(cmd.Parameters["@ID"].Value);
                    return ID;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public void Insert()
        {
            string query = "EXEC InsertPatient " +
               "@ID, " +
               "@FirstName, " +
               "@MiddleName, " +
               "@LastName, " +
               "@Gender, " +
               "@DateOfBirth, " +
               "@Email, " +
               "@PhoneNumber, " +
               "@Address, " +
               "@Nationality, " +
               "@DateRegistered, " +
               "@BranchRegistered, " +
               "@IsInPatient, " +
               "@RoomNumber, " +
               "@ECName, " +
               "@ECRelation, " +
               "@ECPhoneNumber, " +
               "@ECEmail, " +
               "@BloodType, " +
               "@Height, " +
               "@Weight";

            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", this.ID);
                    cmd.Parameters.AddWithValue("@FirstName", this.FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", this.MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", this.LastName);
                    cmd.Parameters.AddWithValue("@Gender", this.Gender);
                    cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Email", this.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", this.Address);
                    cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
                    cmd.Parameters.AddWithValue("@DateRegistered", this.DateRegistered);
                    cmd.Parameters.AddWithValue("@BranchRegistered", this.BranchRegistered);
                    cmd.Parameters.AddWithValue("@IsInPatient", Convert.ToInt32(this.IsInPatient));
                    cmd.Parameters.AddWithValue("@RoomNumber", this.RoomNumber);
                    cmd.Parameters.AddWithValue("@ECName", this.ECName);
                    cmd.Parameters.AddWithValue("@ECRelation", this.ECRelation);
                    cmd.Parameters.AddWithValue("@ECPhoneNumber", this.ECPhoneNumber);
                    cmd.Parameters.AddWithValue("@ECEmail", this.ECEmail);
                    cmd.Parameters.AddWithValue("@BloodType", this.BloodType);
                    cmd.Parameters.AddWithValue("@Height", this.Height);
                    cmd.Parameters.AddWithValue("@Weight", this.Weight);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record successfully added!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Update(Patient updatedPatient)
        {
            string query = "EXEC UpdatePatient " +
               "@ID, " +
               "@FirstName, " +
               "@MiddleName, " +
               "@LastName, " +
               "@Gender, " +
               "@DateOfBirth, " +
               "@Email, " +
               "@PhoneNumber, " +
               "@Address, " +
               "@Nationality, " +
               "@ECName, " +
               "@ECRelation, " +
               "@ECPhoneNumber, " +
               "@ECEmail, " +
               "@BloodType, " +
               "@Height, " +
               "@Weight";

            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", this.ID);
                    cmd.Parameters.AddWithValue("@FirstName", updatedPatient.FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", updatedPatient.MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", updatedPatient.LastName);
                    cmd.Parameters.AddWithValue("@Gender", updatedPatient.Gender);
                    cmd.Parameters.AddWithValue("@DateOfBirth", updatedPatient.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Email", updatedPatient.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", updatedPatient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", updatedPatient.Address);
                    cmd.Parameters.AddWithValue("@Nationality", updatedPatient.Nationality);
                    cmd.Parameters.AddWithValue("@ECName", updatedPatient.ECName);
                    cmd.Parameters.AddWithValue("@ECRelation", updatedPatient.ECRelation);
                    cmd.Parameters.AddWithValue("@ECPhoneNumber", updatedPatient.ECPhoneNumber);
                    cmd.Parameters.AddWithValue("@ECEmail", updatedPatient.ECEmail);
                    cmd.Parameters.AddWithValue("@BloodType", updatedPatient.BloodType);
                    cmd.Parameters.AddWithValue("@Height", updatedPatient.Height);
                    cmd.Parameters.AddWithValue("@Weight", updatedPatient.Weight);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record successfully updated!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete()
        {
            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                try
                {
                    string query = "EXEC DeletePatient @ID";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", this.ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record successfully deleted!");
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public static Patient FindByID(string ID)
        {
            Patient patient = new Patient();

            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                try
                {
                    string query = "SELECT * FROM dbo.FindPatientByID (@ID)";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        patient.ID = reader["ID"].ToString();
                        patient.FirstName = reader["FirstName"].ToString();
                        patient.MiddleName = reader["MiddleName"].ToString();
                        patient.LastName = reader["LastName"].ToString();
                        patient.Gender = reader["Gender"].ToString();
                        patient.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                        patient.Email = reader["Email"].ToString();
                        patient.PhoneNumber = reader["PhoneNumber"].ToString();
                        patient.Address = reader["Address"].ToString();
                        patient.Nationality = reader["Nationality"].ToString();
                        patient.DateRegistered = DateTime.Parse(reader["DateRegistered"].ToString());
                        patient.BranchRegistered = reader["BranchRegistered"].ToString();
                        patient.IsInPatient = Convert.ToBoolean(reader["IsInPatient"]);
                        patient.RoomNumber = reader["RoomNumber"].ToString();
                        //
                        patient.ECName = reader["ECName"].ToString();
                        patient.ECRelation = reader["ECRelation"].ToString();
                        patient.ECPhoneNumber = reader["ECPhoneNumber"].ToString();
                        patient.ECEmail = reader["ECEmail"].ToString();
                        //
                        patient.BloodType = reader["BloodType"].ToString();
                        patient.Height = float.Parse(reader["Height"].ToString());
                        patient.Weight = float.Parse(reader["Weight"].ToString());
                    }
                    return patient;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        public static Patient FindByPhoneNumber(string PhoneNumber)
        {
            Patient patient = new Patient();

            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                try
                {
                    string query = "SELECT * FROM dbo.FindPatientByPhoneNumber (@PhoneNumber)";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        patient.ID = reader["ID"].ToString();
                        patient.FirstName = reader["FirstName"].ToString();
                        patient.MiddleName = reader["MiddleName"].ToString();
                        patient.LastName = reader["LastName"].ToString();
                        patient.Gender = reader["Gender"].ToString();
                        patient.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                        patient.Email = reader["Email"].ToString();
                        patient.PhoneNumber = reader["PhoneNumber"].ToString();
                        patient.Address = reader["Address"].ToString();
                        patient.Nationality = reader["Nationality"].ToString();
                        patient.DateRegistered = DateTime.Parse(reader["DateRegistered"].ToString());
                        patient.BranchRegistered = reader["BranchRegistered"].ToString();
                        patient.IsInPatient = Convert.ToBoolean(reader["IsInPatient"]);
                        patient.RoomNumber = reader["RoomNumber"].ToString();
                        //
                        patient.ECName = reader["ECName"].ToString();
                        patient.ECRelation = reader["ECRelation"].ToString();
                        patient.ECPhoneNumber = reader["ECPhoneNumber"].ToString();
                        patient.ECEmail = reader["ECEmail"].ToString();
                        //
                        patient.BloodType = reader["BloodType"].ToString();
                        patient.Height = float.Parse(reader["Height"].ToString());
                        patient.Weight = float.Parse(reader["Weight"].ToString());
                    }
                    return patient;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public ExaminationRecord GetRecentExaminationRecord()
        {
            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                try
                {
                    string query = "SELECT TOP 1 * FROM ExaminationRecord WHERE PatientID = @PatientID ORDER BY DateAndTime DESC";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", this.ID);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ExaminationRecord examinationRecord = new ExaminationRecord()
                        {
                            ID = reader["ID"].ToString(),
                            DateAndTime = DateTime.Parse(reader["DateAndTime"].ToString()),
                            PatientID = reader["PatientID"].ToString(),
                            PhysicianID = reader["PhysicianID"].ToString(),
                            Diagnosis = reader["Diagnosis"].ToString(),
                            IsRemovedFromQueue = Convert.ToBoolean(reader["IsRemovedFromQueue"])
                        };
                        return examinationRecord;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }
        }
    }
}
