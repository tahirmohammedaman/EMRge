using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EMRge.Entities
{
    public class Employee
    {
        public string ID { get; set; }
        public string Department { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string Branch { get; set; }
        public double Salary { get; set; }
        public DateTime DateJoined { get; set; }
        public bool CurrentlyWorking { get; set; }

        // Emergency Contact Info
        public string ECName { get; set; }
        public string ECRelation { get; set; }
        public string ECPhoneNumber { get; set; }
        public string ECEmail { get; set; }

        // --
        public bool IsDeleted { get; set; } = false;

        public static List<Employee> GetAllEmployees(string SearchKey = "", string Branch = "", string Department = "", string MinSalary = "", string MaxSalary = "", string SortBy = "Department", bool Ascending = true)
        {
            List<Employee> list = new List<Employee>();
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "EXEC GetAllEmployees " +
                        "@SearchKey, " +
                        "@Branch, " +
                        "@Department, " +
                        "@MinSalary, " +
                        "@MaxSalary, " +
                        "@SortBy, " +
                        "@Ascending";

                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchKey", SearchKey);
                    cmd.Parameters.AddWithValue("@Branch", Branch);
                    cmd.Parameters.AddWithValue("@Department", Department);
                    cmd.Parameters.AddWithValue("@MinSalary", MinSalary);
                    cmd.Parameters.AddWithValue("@MaxSalary", MaxSalary);
                    cmd.Parameters.AddWithValue("@SortBy", SortBy);
                    cmd.Parameters.AddWithValue("@Ascending", Convert.ToInt32(Ascending));

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee()
                        {
                            ID = reader["ID"].ToString(),
                            Department = reader["Department"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Address = reader["Address"].ToString(),
                            Nationality = reader["Nationality"].ToString(),
                            Branch = reader["Branch"].ToString(),
                            Salary = double.Parse(reader["Salary"].ToString()),
                            DateJoined = DateTime.Parse(reader["DateJoined"].ToString()),
                            CurrentlyWorking = Convert.ToBoolean(reader["CurrentlyWorking"]),
                            //
                            ECName = reader["ECName"].ToString(),
                            ECRelation = reader["ECRelation"].ToString(),
                            ECPhoneNumber = reader["ECPhoneNumber"].ToString(),
                            ECEmail = reader["ECEmail"].ToString(),
                        };
                        list.Add(employee);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public static string GenerateEmployeeID()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    conn.Open();
                    string query = "EXEC GenerateEmployeeID @ID OUTPUT";
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
            string query = "EXEC InsertEmployee " +
               "@ID, " +
               "@Department, " +
               "@FirstName, " +
               "@MiddleName, " +
               "@LastName, " +
               "@Gender, " +
               "@DateOfBirth, " +
               "@Email, " +
               "@PhoneNumber, " +
               "@Address, " +
               "@Nationality, " +
               "@Branch, " +
               "@Salary, " +
               "@DateJoined, " +
               "@CurrentlyWorking, " +
               "@ECName, " +
               "@ECRelation, " +
               "@ECPhoneNumber, " +
               "@ECEmail";

            using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", this.ID);
                cmd.Parameters.AddWithValue("@Department", this.Department);
                cmd.Parameters.AddWithValue("@FirstName", this.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", this.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", this.LastName);
                cmd.Parameters.AddWithValue("@Gender", this.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", this.DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", this.Address);
                cmd.Parameters.AddWithValue("@Nationality", this.Nationality);
                cmd.Parameters.AddWithValue("@Branch", this.Branch);
                cmd.Parameters.AddWithValue("@Salary", this.Salary);
                cmd.Parameters.AddWithValue("@DateJoined", this.DateJoined);
                cmd.Parameters.AddWithValue("@CurrentlyWorking", Convert.ToInt32(this.CurrentlyWorking));
                cmd.Parameters.AddWithValue("@ECName", this.ECName);
                cmd.Parameters.AddWithValue("@ECRelation", this.ECRelation);
                cmd.Parameters.AddWithValue("@ECPhoneNumber", this.ECPhoneNumber);
                cmd.Parameters.AddWithValue("@ECEmail", this.ECEmail);

                cmd.ExecuteNonQuery();
                this.SetDefaultCredentials();
                MessageBox.Show("Record successfully added!");
            }
        }

        public static int[] GetCredentials(string ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM EmployeeCredentials WHERE EmployeeID = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    var reader = cmd.ExecuteReader();

                    int[] credentials = new int[17];
                    while (reader.Read())
                    {
                        for (int i = 0; i < 17; i++)
                            credentials[i] = Convert.ToInt32(reader[i + 1]);
                    }
                    return credentials;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void SetDefaultCredentials()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    conn.Open();
                    string query = "INSERT INTO EmployeeCredentials VALUES ('" +
                        this.ID + "', ";

                    switch (this.Department)
                    {
                        case "Admissions (Front-desk)":
                            query += "1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'mypass')";
                            break;
                        case "General Surgery":
                        case "Gynecology":
                        case "Internal Medicine":
                        case "Intensive Care Unit (ICU)":
                        case "Pediatrics":
                            query += "1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'mypass')";
                            break;
                        case "Janitorial":
                        case "Security":
                            query += "0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'mypass')";
                            break;
                        case "Laboratory":
                            query += "1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'mypass')";
                            break;
                        case "Finance":
                            query += "1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'mypass')";
                            break;
                        case "Administration":
                            query += "1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 'mypass')";
                            break;
                        default:
                            query += "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'mypass')";
                            break;
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateCredentials(int[] credentials)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "UPDATE EmployeeCredentials SET " +
                        "Cred1 = " + credentials[0] +
                        ", Cred2 = " + credentials[1] +
                        ", Cred3 = " + credentials[2] +
                        ", Cred4 = " + credentials[3] +
                        ", Cred5 = " + credentials[4] +
                        ", Cred6 = " + credentials[5] +
                        ", Cred7 = " + credentials[6] +
                        ", Cred8 = " + credentials[7] +
                        ", Cred9 = " + credentials[8] +
                        ", Cred10 = " + credentials[9] +
                        ", Cred11 = " + credentials[10] +
                        ", Cred12 = " + credentials[11] +
                        ", Cred13 = " + credentials[12] +
                        ", Cred14 = " + credentials[13] +
                        ", Cred15 = " + credentials[14] +
                        ", Cred16 = " + credentials[15] +
                        ", Cred17 = " + credentials[16] +
                        " WHERE EmployeeID = '" + this.ID + "'";
                    
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee credentials updated successfully!");
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
