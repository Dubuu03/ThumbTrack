using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Main
{
    public partial class formSettings : Form
    {
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();

        public formSettings()
        {
            InitializeComponent();
            InitializePlaceholders();
            SetPanelBorderRadius();
            LoadTimePeriods();
            GetEventNameForToday();
            InitializeTimeInputValidation();
        }

        #region UI Initialization

        private void InitializePlaceholders()
        {
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

        private void SetPanelBorderRadius()
        {
            RoundedPanel[] panels = { roundedPanel5, roundedPanel6, roundedPanel7, roundedPanel8, roundedPanel9, roundedPanel10 };

            foreach (var panel in panels)
            {
                if (panel is RoundedPanel roundedPanel)
                {
                    roundedPanel.BorderRadius = 15; // Set to desired radius for each panel
                }
            }
        }

        #endregion

        #region Event Handlers

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all required time fields have valid values
            if (AreTimeInputsValid())
            {
                // Validate time format for each time field
                if (IsTimeFormatValid(txtAmInStart.Text) && IsTimeFormatValid(txtAmInEnd.Text) ||
                    IsTimeFormatValid(txtAmOutStart.Text) && IsTimeFormatValid(txtAmOutEnd.Text) ||
                    IsTimeFormatValid(txtPmInStart.Text) && IsTimeFormatValid(txtPmInEnd.Text) ||
                    IsTimeFormatValid(txtPmOutStart.Text) && IsTimeFormatValid(txtPmOutEnd.Text))
                {
                    if (ValidateTimeOrder())
                    {
                        UpdateTimePeriods();  
                    }
                    else
                    {
                        MessageBox.Show("Please ensure each start time is earlier than the corresponding end time.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid time values in the format H:mm or HH:mm.");
                }
            }
            else
            {
                MessageBox.Show("Please enter at least one valid time value.");
            }
        }


        private void btnSubmitEvent_Click_1(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text.Trim();
            if (!string.IsNullOrEmpty(eventName))
            {
                SaveEvent(eventName);
            }
            else
            {
                MessageBox.Show("Please enter an event name.");
            }
        }

        #endregion

        #region Database Operations

        private void UpdateTimePeriods()
        {
            try
            {
                Database db = new Database();
                UpdateTimePeriod("AMin", txtAmInStart, txtAmInEnd, db);
                UpdateTimePeriod("AMout", txtAmOutStart, txtAmOutEnd, db);
                UpdateTimePeriod("PMin", txtPmInStart, txtPmInEnd, db);
                UpdateTimePeriod("PMout", txtPmOutStart, txtPmOutEnd, db);

                MessageBox.Show("Time updated successfully!");
                LoadTimePeriods();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void SaveEvent(string eventName)
        {
            try
            {
                Database db = new Database();
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO tblEvent (eventName, Date) VALUES (@eventName, @eventDate)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eventName", eventName);
                        command.Parameters.AddWithValue("@eventDate", DateTime.Now);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event saved successfully!");
                            txtEventName.Clear();
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
            GetEventNameForToday();
        }

        private void UpdateTimePeriod(string period, TextBox startTextBox, TextBox endTextBox, Database db)
        {
            string startTime = startTextBox.Text.Trim();
            string endTime = endTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(startTime) && startTime != placeholders[startTextBox] &&
                !string.IsNullOrEmpty(endTime) && endTime != placeholders[endTextBox])
            {
                db.UpdateTime(period, ConvertTextToTime(startTime), ConvertTextToTime(endTime));
            }
        }

        private void LoadTimePeriods()
        {
            Database db = new Database();
            string query = "SELECT Period, StartTime, EndTime FROM tblTime";
            DataTable dt = db.ExecuteQuery(query);

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
                        case "AMin": lbTIam.Text = timeRange; break;
                        case "AMout": lbTOam.Text = timeRange; break;
                        case "PMin": lbTIpm.Text = timeRange; break;
                        case "PMout": lbTOpm.Text = timeRange; break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No time periods found in the database.");
            }
        }

        private void GetEventNameForToday()
        {
            DateTime currentDate = DateTime.Now.Date;
            string eventName = "No Event Yet";

            try
            {
                Database db = new Database();
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT eventName FROM tblEvent WHERE Date = @eventDate";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@eventDate", currentDate);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            eventName = result.ToString();
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
                UpdateEventName(eventName);
            }
        }

        private void UpdateEventName(string eventName)
        {
            lbeventName.Text = eventName;
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

        #endregion

        #region TextBox Placeholder Logic

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == placeholders[textBox])
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ChangeTextColor(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.White;
            }
        }

        #endregion

        #region Validation and Helper Methods

        private bool AreTimeInputsValid()
        {
            if (!string.IsNullOrEmpty(txtAmInStart.Text) && txtAmInStart.Text != placeholders[txtAmInStart] &&
                !string.IsNullOrEmpty(txtAmInEnd.Text) && txtAmInEnd.Text != placeholders[txtAmInEnd])
            {
                return true;
            }

            if (!string.IsNullOrEmpty(txtAmOutStart.Text) && txtAmOutStart.Text != placeholders[txtAmOutStart] &&
                !string.IsNullOrEmpty(txtAmOutEnd.Text) && txtAmOutEnd.Text != placeholders[txtAmOutEnd])
            {
                return true;
            }

            if (!string.IsNullOrEmpty(txtPmInStart.Text) && txtPmInStart.Text != placeholders[txtPmInStart] &&
                !string.IsNullOrEmpty(txtPmInEnd.Text) && txtPmInEnd.Text != placeholders[txtPmInEnd])
            {
                return true;
            }

            if (!string.IsNullOrEmpty(txtPmOutStart.Text) && txtPmOutStart.Text != placeholders[txtPmOutStart] &&
                !string.IsNullOrEmpty(txtPmOutEnd.Text) && txtPmOutEnd.Text != placeholders[txtPmOutEnd])
            {
                return true;
            }

            return false;
        }

        private void ClearTextboxes()
        {
            foreach (var textBox in placeholders.Keys)
            {
                textBox.Clear();
                textBox.Text = placeholders[textBox];
                textBox.ForeColor = Color.Gray;
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and colon
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Block the key press if it's not a digit or colon
            }

            // Ensure only one colon is allowed
            TextBox textBox = sender as TextBox;
            if (textBox != null && e.KeyChar == ':' && textBox.Text.Contains(":"))
            {
                e.Handled = true; // Block the key press if a colon is already present
            }
        }

        private void InitializeTimeInputValidation()
        {
            // Assign the KeyPress event handler to each time-related TextBox
            txtAmInStart.KeyPress += txtTime_KeyPress;
            txtAmInEnd.KeyPress += txtTime_KeyPress;
            txtAmOutStart.KeyPress += txtTime_KeyPress;
            txtAmOutEnd.KeyPress += txtTime_KeyPress;
            txtPmInStart.KeyPress += txtTime_KeyPress;
            txtPmInEnd.KeyPress += txtTime_KeyPress;
            txtPmOutStart.KeyPress += txtTime_KeyPress;
            txtPmOutEnd.KeyPress += txtTime_KeyPress;
        }

        private bool ValidateTimeOrder()
        {
            bool isValid = true;

            // Validate order for AM In Start and AM In End if both are non-empty and not placeholders
            if (!string.IsNullOrEmpty(txtAmInStart.Text) && txtAmInStart.Text != placeholders[txtAmInStart] &&
                !string.IsNullOrEmpty(txtAmInEnd.Text) && txtAmInEnd.Text != placeholders[txtAmInEnd])
            {
                isValid &= ValidateTimePair(txtAmInStart.Text, txtAmInEnd.Text);
            }

            // Validate order for AM Out Start and AM Out End
            if (!string.IsNullOrEmpty(txtAmOutStart.Text) && txtAmOutStart.Text != placeholders[txtAmOutStart] &&
                !string.IsNullOrEmpty(txtAmOutEnd.Text) && txtAmOutEnd.Text != placeholders[txtAmOutEnd])
            {
                isValid &= ValidateTimePair(txtAmOutStart.Text, txtAmOutEnd.Text);
            }

            // Validate order for PM In Start and PM In End
            if (!string.IsNullOrEmpty(txtPmInStart.Text) && txtPmInStart.Text != placeholders[txtPmInStart] &&
                !string.IsNullOrEmpty(txtPmInEnd.Text) && txtPmInEnd.Text != placeholders[txtPmInEnd])
            {
                isValid &= ValidateTimePair(txtPmInStart.Text, txtPmInEnd.Text);
            }

            // Validate order for PM Out Start and PM Out End
            if (!string.IsNullOrEmpty(txtPmOutStart.Text) && txtPmOutStart.Text != placeholders[txtPmOutStart] &&
                !string.IsNullOrEmpty(txtPmOutEnd.Text) && txtPmOutEnd.Text != placeholders[txtPmOutEnd])
            {
                isValid &= ValidateTimePair(txtPmOutStart.Text, txtPmOutEnd.Text);
            }

            return isValid;
        }


        // Helper method to check if the time is in the correct H:mm or HH:mm format
        private bool IsTimeFormatValid(string time)
        {
            // Define accepted formats
            string[] formats = { "H:mm", "HH:mm" };
            DateTime parsedTime;

            // Check that the input contains a colon and matches the expected time format
            if (time.Contains(":") && DateTime.TryParseExact(time, formats, null, System.Globalization.DateTimeStyles.None, out parsedTime))
            {
                // Split the time by the colon to check hour and minute ranges
                string[] timeParts = time.Split(':');
                if (timeParts.Length == 2)
                {
                    if (int.TryParse(timeParts[0], out int hour) && int.TryParse(timeParts[1], out int minute))
                    {
                        // Validate that hour and minute are within valid ranges
                        if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                        {
                            return true;
                        }
                    }
                }
            }
            return false; // Return false if format is incorrect
        }


        private bool ValidateTimePair(string startTime, string endTime)
        {
            // Ensure the input is in "H:mm" or "HH:mm" format
            if (DateTime.TryParseExact(startTime, new[] { "H:mm", "HH:mm" }, null, System.Globalization.DateTimeStyles.None, out DateTime start) &&
                DateTime.TryParseExact(endTime, new[] { "H:mm", "HH:mm" }, null, System.Globalization.DateTimeStyles.None, out DateTime end))
            {
                // Ensure the start time is earlier than the end time
                return start < end;
            }

            // Invalid time format or order, return false
            return false;
        }


        #endregion

    }
}
