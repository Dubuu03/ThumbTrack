using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Main
{
    internal class Database
    {
        private string connectionString = "Server=localhost;Database=dbams;Uid=root;Pwd=;Allow Zero Datetime=True;Convert Zero Datetime=True;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


        public DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable ExecuteQuery(MySqlCommand command)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    command.Connection = conn; 
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}");
                return null; 
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public int GetStudentCount()
        {
            int studentCount = 0;
            string query = "SELECT COUNT(StudentID) FROM tblstudents";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        studentCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return studentCount;
        }

        public int GetTimeInAMCount()
        {
            int timeInAMCount = 0;
            string query = "SELECT COUNT(TimeInAM) FROM tblattendance WHERE TimeInAM IS NOT NULL AND Date = CURDATE()";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        timeInAMCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return timeInAMCount;
        }

        public int GetTimeOutAMCount()
        {
            int timeOutAMCount = 0;
            string query = "SELECT COUNT(TimeOutAM) FROM tblattendance WHERE TimeOutAM IS NOT NULL AND Date = CURDATE()";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        timeOutAMCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return timeOutAMCount;
        }

        public int GetTimeInPMCount()
        {
            int timeInPMCount = 0;
            string query = "SELECT COUNT(TimeInPM) FROM tblattendance WHERE TimeInPM IS NOT NULL AND Date = CURDATE()";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        timeInPMCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return timeInPMCount;
        }

        public int GetTimeOutPMCount()
        {
            int timeOutPMCount = 0;
            string query = "SELECT COUNT(TimeOutPM) FROM tblattendance WHERE TimeOutPM IS NOT NULL AND Date = CURDATE()";

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        timeOutPMCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return timeOutPMCount;
        }
        public string HashPassword(string password)
        {
            byte[] salt = new byte[16]; 
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Use PBKDF2 to hash the password with the salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(32);

            // Combine the salt and hash
            byte[] hashBytes = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, hashBytes, 0, salt.Length);
            Array.Copy(hash, 0, hashBytes, salt.Length, hash.Length);

            string hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword.Substring(0, 64);
        }



        public bool RegisterStudent(int studentID, string name, string course, int year, string section, string password, string photoPath)
        {
            bool isInserted = false;
            string hashedPassword = HashPassword(password);

            string query = "INSERT INTO tblstudents (StudentID, Name, Password, Course, Year, Section, AccessLevel, Photo) " +
                           "VALUES (@StudentID, @Name, @Password, @Course, @Year, @Section, 'Student', @Photo)";

            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Photo", photoPath); 

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        isInserted = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return isInserted;
        }



        public (bool isVerified, string accessLevel) VerifyStudentID(int studentID, string password)
        {
            string query = "SELECT Password, AccessLevel FROM tblstudents WHERE StudentID = @StudentID";
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["Password"].ToString();
                                string accessLevel = reader["AccessLevel"].ToString();

                                // Verify the password
                                bool isVerified = VerifyPassword(password, storedHash);
                                return (isVerified, accessLevel);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return (false, null);
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, salt.Length);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(32);

            byte[] hashWithSalt = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, hashWithSalt, 0, salt.Length);
            Array.Copy(hash, 0, hashWithSalt, salt.Length, hash.Length);

            // Compare the stored hash with the newly created hash
            return Convert.ToBase64String(hashWithSalt) == storedHash;
        }



        public bool StudentIDExists(int studentID)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM tblstudents WHERE StudentID = @StudentID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; 
                }
            }
        }

        public bool UpdateStudent(int studentID, string name, string course, int year, string section, string password, string photoPath)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE tblstudents SET 
                                Name = @Name, 
                                Course = @Course, 
                                Year = @Year, 
                                Section = @Section" +
                                        (password != null ? ", Password = @Password" : "") +
                                        " WHERE StudentID = @StudentID";

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    if (password != null)
                    {
                        cmd.Parameters.AddWithValue("@Password", HashPassword(password));
                    }

                    // Execute the command and return whether the update was successful
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public string GetOldPassword(int studentID)
        {
            string password = null;

            string query = "SELECT Password FROM tblstudents WHERE StudentID = @StudentID";

            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    try
                    {
                        conn.Open();
                        password = cmd.ExecuteScalar()?.ToString(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return password;
        }

        public void UpdateTime(string period, string startTime, string endTime)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = "UPDATE tblTime SET StartTime = @StartTime, EndTime = @EndTime WHERE Period = @Period";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartTime", TimeSpan.Parse(startTime));
                    cmd.Parameters.AddWithValue("@EndTime", TimeSpan.Parse(endTime));
                    cmd.Parameters.AddWithValue("@Period", period);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertAttendance(string studentId, string name, string date, string timeField, DateTime time, string course, int year, string section, string remarks)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = $"INSERT INTO tblattendance (StudentID, Name, Date, {timeField}, Course, `Year`, Section, Remarks) VALUES (@StudentID, @Name, @Date, @Time, @Course, @Year, @Section, @Remarks)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Remarks", remarks);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void UpdateAttendance(string studentId, string date, string timeField, DateTime time)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = $"UPDATE tblattendance SET {timeField} = @Time WHERE StudentID = @StudentID AND Date = @Date";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Time", time);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRemarks(string studentId, string date, string remarks)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "UPDATE tblattendance SET Remarks = @Remarks WHERE StudentID = @StudentID AND Date = @Date";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Remarks", remarks);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAttendanceRecords(string studentId, string date)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM tblattendance WHERE StudentID = @StudentID AND Date = @Date";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

    }


}

