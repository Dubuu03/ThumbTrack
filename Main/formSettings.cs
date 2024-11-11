using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Main
{
    public partial class formSettings : Form
    {
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();
        public formSettings()
        {
            InitializeComponent();
            LoadTimePeriods();
            GetEventNameForToday();

            placeholders.Add(txtEventName, "Enter Event Name");
            placeholders.Add(txtAmInStart, "Time Start");
            placeholders.Add(txtAmInEnd, "Time End");
            placeholders.Add(txtAmOutStart, "Time Start");
            placeholders.Add(txtAmOutEnd, "Time End");
            placeholders.Add(txtPmInStart, "Time Start");
            placeholders.Add(txtPmInEnd, "Time End");
            placeholders.Add(txtPmOutStart, "Time Start");
            placeholders.Add(txtPmOutEnd, "Time End");

            foreach (var textBox in placeholders.Keys)
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray; 

                textBox.Enter += RemovePlaceholder;
                textBox.Leave += SetPlaceholder;
                textBox.TextChanged += ChangeTextColor;
            }

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            string amInStart = txtAmInStart.Text.Trim();
            string amOutStart = txtAmOutStart.Text.Trim();
            string amInEnd = txtAmInEnd.Text.Trim();
            string amOutEnd = txtAmOutEnd.Text.Trim();

            string pmInStart = txtPmInStart.Text.Trim();
            string pmOutStart = txtPmOutStart.Text.Trim();
            string pmInEnd = txtPmInEnd.Text.Trim();
            string pmOutEnd = txtPmOutEnd.Text.Trim();

            if (string.IsNullOrEmpty(amInStart) && string.IsNullOrEmpty(amOutStart) &&
                string.IsNullOrEmpty(amInEnd) && string.IsNullOrEmpty(amOutEnd) &&
                string.IsNullOrEmpty(pmInStart) && string.IsNullOrEmpty(pmOutStart) &&
                string.IsNullOrEmpty(pmInEnd) && string.IsNullOrEmpty(pmOutEnd))
            {
                MessageBox.Show("No input provided. Please enter at least one time value.");
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(amInStart) && !string.IsNullOrEmpty(amInEnd))
                {
                    db.UpdateTime("AMin", ConvertTextToTime(amInStart), ConvertTextToTime(amInEnd));
                }

                if (!string.IsNullOrEmpty(amOutStart) && !string.IsNullOrEmpty(amOutEnd))
                {
                    db.UpdateTime("AMout", ConvertTextToTime(amOutStart), ConvertTextToTime(amOutEnd));
                }

                if (!string.IsNullOrEmpty(pmInStart) && !string.IsNullOrEmpty(pmInEnd))
                {
                    db.UpdateTime("PMin", ConvertTextToTime(pmInStart), ConvertTextToTime(pmInEnd));
                }

                if (!string.IsNullOrEmpty(pmOutStart) && !string.IsNullOrEmpty(pmOutEnd))
                {
                    db.UpdateTime("PMout", ConvertTextToTime(pmOutStart), ConvertTextToTime(pmOutEnd));
                }

                MessageBox.Show("Time updated successfully!");

                LoadTimePeriods();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            ClearTextboxes();
        }

        private void ClearTextboxes()
        {
            txtAmInStart.Clear();
            txtAmOutStart.Clear();
            txtAmInEnd.Clear();
            txtAmOutEnd.Clear();
            txtPmInStart.Clear();
            txtPmOutStart.Clear();
            txtPmInEnd.Clear();
            txtPmOutEnd.Clear();
        }

        private string ConvertTextToTime(string input)
        {
            var parts = input.Split(':');

            if (parts.Length > 0 && int.TryParse(parts[0], out int hour) && hour >= 0 && hour < 24)
            {
                int minute = 0, second = 0;

                if (parts.Length > 1 && int.TryParse(parts[1], out minute) && minute >= 0 && minute < 60)
                {
                    if (parts.Length > 2 && int.TryParse(parts[2], out second) && second >= 0 && second < 60)
                    {
                        return $"{hour:D2}:{minute:D2}:{second:D2}";
                    }
                    return $"{hour:D2}:{minute:D2}:00";
                }

                return $"{hour:D2}:00:00";
            }

            return "00:00:00";
        }

        private void LoadTimePeriods()
        {
            Database db = new Database();

            string query = "SELECT Period, StartTime, EndTime FROM tblTime";
            DataTable dt = db.ExecuteQuery(query);

            lbTIam.Text = string.Empty;
            lbTOam.Text = string.Empty;
            lbTIpm.Text = string.Empty;
            lbTOpm.Text = string.Empty;

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string period = row["Period"].ToString();
                    TimeSpan startTime = TimeSpan.Parse(row["StartTime"].ToString());
                    TimeSpan endTime = TimeSpan.Parse(row["EndTime"].ToString());

                    string timeRange = $"{startTime:hh\\:mm} - {endTime:hh\\:mm}";

                    switch (period)
                    {
                        case "AMin":
                            lbTIam.Text = timeRange;
                            break;
                        case "AMout":
                            lbTOam.Text = timeRange;
                            break;
                        case "PMin":
                            lbTIpm.Text = timeRange;
                            break;
                        case "PMout":
                            lbTOpm.Text = timeRange;
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No time periods found in the database.");
            }
        }

        private void btnSubmitEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text.Trim();
            DateTime eventDate = DateTime.Now;

            if (string.IsNullOrEmpty(eventName))
            {
                MessageBox.Show("Please enter an event name.");
                return;
            }

            try
            {
                Database db = new Database();
                using (var connection = db.GetConnection())
                {
                    connection.Open(); // Open the database connection

                    // Insert new event
                    string query = "INSERT INTO tblEvent (eventName, Date) VALUES (@eventName, @eventDate)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eventName", eventName);
                        command.Parameters.AddWithValue("@eventDate", eventDate);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event saved successfully!");
                            txtEventName.Clear();

                            // Update the label with the new event name
                            UpdateEventName(eventName);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the event.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // Check for events on the current date
            GetEventNameForToday();
        }

        private void GetEventNameForToday()
        {
            DateTime currentDate = DateTime.Now.Date; // Get the current date
            string eventName = "No Event Yet"; // Default message

            try
            {
                Database db = new Database();
                using (var connection = db.GetConnection())
                {
                    connection.Open(); // Open the database connection
                    string query = "SELECT eventName FROM tblEvent WHERE Date = @eventDate";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eventDate", currentDate);
                        object result = command.ExecuteScalar(); // Execute the query and get the result

                        if (result != null)
                        {
                            eventName = result.ToString(); // Update the event name if found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching the event: " + ex.Message);
            }
            finally
            {
                // Update the label with the event name or "No Event Yet"
                UpdateEventName(eventName);
            }
        }

        private void UpdateEventName(string eventName)
        {
            lbeventName.Text = eventName; // Update the label with the event name
        }

        private void txtAmInEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbTIam_Click(object sender, EventArgs e)
        {

        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray; // Keep placeholder text gray
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == placeholders[textBox])
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText; // Regular text color
            }
        }

        private void ChangeTextColor(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (placeholders[textBox] == "Time Start" || placeholders[textBox] == "Time End")
                {
                    textBox.ForeColor = Color.White; 
                }
                else if (placeholders[textBox] == "Enter Event Name")
                {
                    textBox.ForeColor = Color.Black; 
                }
            }
        }

    }
}
