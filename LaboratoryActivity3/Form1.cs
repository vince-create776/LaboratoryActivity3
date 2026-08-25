using System;
using System.Windows.Forms;

namespace LaboratoryActivity3
{
    public partial class Form1 : Form
    {
        private int QueueCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void patientsType_TextChanged(object sender, EventArgs e)
        {
        }

        // ADD TO QUEUE
        private void button1_Click(object sender, EventArgs e)
        {
            string name = patientsName.Text.Trim();
            string type = patientType.Text.Trim();
            string reason = reasonForVisit.Text.Trim();
            int age;

            // Check patient name
            if (name == "")
            {
                MessageBox.Show("Patient name is required");
                return;
            }

            // Check age
            if (!int.TryParse(patientsAge.Text.Trim(), out age))
            {
                MessageBox.Show("Patient age must be a number");
                return;
            }

            if (age < 0 || age > 120)
            {
                MessageBox.Show("Patient age must be between 0 and 120");
                return;
            }

            // Check reason
            if (reason == "")
            {
                MessageBox.Show("Reason for visit is required");
                return;
            }

            // Check patient type
            if (type == "")
            {
                MessageBox.Show("Patient type is required");
                return;
            }

            // Determine priority
            string priority;

            if (type == "Emergency")
            {
                priority = "EMERGENCY";
            }
            else if (type == "Senior")
            {
                priority = "SENIOR PRIORITY";
            }
            else if (type == "Pregnant")
            {
                priority = "PRIORITY";
            }
            else if (type == "Regular")
            {
                priority = "REGULAR";
            }
            else
            {
                MessageBox.Show("Invalid patient type");
                return;
            }

            // Generate queue number
            string queueNumber = "Q" + QueueCounter.ToString("D3");

            // Display results
            queueNumberLbl.Text = queueNumber;
            resultsLbl.Text = type;
            informationLbl.Text = priority;

            // Increase queue counter
            QueueCounter++;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void queueNumberLbl_Click(object sender, EventArgs e)
        {
        }

        private void resultsLbl_Click(object sender, EventArgs e)
        {
        }

        private void informationLbl_Click(object sender, EventArgs e)
        {
        }

        // CLEAR
        private void clear_Click(object sender, EventArgs e)
        {
            patientsName.Clear();
            patientsAge.Clear();
            reasonForVisit.Clear();

            patientType.SelectedIndex = -1;

            queueNumberLbl.Text = "";
            resultsLbl.Text = "";
            informationLbl.Text = "";
        }

        private void patientType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void reasonForVisit_TextChanged(object sender, EventArgs e)
        {
        }

        private void reason_Click(object sender, EventArgs e)
        {
        }

        private void type_Click(object sender, EventArgs e)
        {
        }

        private void patientsAge_TextChanged(object sender, EventArgs e)
        {
        }

        private void age_Click(object sender, EventArgs e)
        {
        }

        private void patientsName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}