namespace LaboratoryActivity3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.patientsName = new System.Windows.Forms.TextBox();
            this.patientsAge = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.reasonForVisit = new System.Windows.Forms.TextBox();
            this.reason = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.patientType = new System.Windows.Forms.ComboBox();
            this.addToQueue = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.informationLbl = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.resultsLbl = new System.Windows.Forms.Label();
            this.queueNumberLbl = new System.Windows.Forms.Label();
            this.patientTypeLbl = new System.Windows.Forms.Label();
            this.PriorityLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(61, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(79, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Patients Name:";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientsName
            // 
            this.patientsName.Location = new System.Drawing.Point(146, 91);
            this.patientsName.Name = "patientsName";
            this.patientsName.Size = new System.Drawing.Size(190, 20);
            this.patientsName.TabIndex = 1;
            this.patientsName.TextChanged += new System.EventHandler(this.patientsName_TextChanged);
            // 
            // patientsAge
            // 
            this.patientsAge.Location = new System.Drawing.Point(146, 117);
            this.patientsAge.Name = "patientsAge";
            this.patientsAge.Size = new System.Drawing.Size(100, 20);
            this.patientsAge.TabIndex = 3;
            this.patientsAge.TextChanged += new System.EventHandler(this.patientsAge_TextChanged);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(111, 120);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(29, 13);
            this.age.TabIndex = 2;
            this.age.Text = "Age:";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // reasonForVisit
            // 
            this.reasonForVisit.Location = new System.Drawing.Point(146, 169);
            this.reasonForVisit.Name = "reasonForVisit";
            this.reasonForVisit.Size = new System.Drawing.Size(190, 20);
            this.reasonForVisit.TabIndex = 7;
            this.reasonForVisit.TextChanged += new System.EventHandler(this.reasonForVisit_TextChanged);
            // 
            // reason
            // 
            this.reason.AutoSize = true;
            this.reason.Location = new System.Drawing.Point(53, 172);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(87, 13);
            this.reason.TabIndex = 6;
            this.reason.Text = "Reason For Visit:";
            this.reason.Click += new System.EventHandler(this.reason_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(70, 146);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(70, 13);
            this.type.TabIndex = 4;
            this.type.Text = "Patient Type:";
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // patientType
            // 
            this.patientType.FormattingEnabled = true;
            this.patientType.Items.AddRange(new object[] {
            "PREGNANT",
            "SENIOR ",
            "EMERGENCY",
            "REGULAR"});
            this.patientType.Location = new System.Drawing.Point(146, 142);
            this.patientType.Name = "patientType";
            this.patientType.Size = new System.Drawing.Size(190, 21);
            this.patientType.TabIndex = 8;
            this.patientType.SelectedIndexChanged += new System.EventHandler(this.patientType_SelectedIndexChanged);
            // 
            // addToQueue
            // 
            this.addToQueue.Location = new System.Drawing.Point(56, 233);
            this.addToQueue.Name = "addToQueue";
            this.addToQueue.Size = new System.Drawing.Size(133, 23);
            this.addToQueue.TabIndex = 9;
            this.addToQueue.Text = "ADD TO QUEUE";
            this.addToQueue.UseVisualStyleBackColor = true;
            this.addToQueue.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(209, 233);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // informationLbl
            // 
            this.informationLbl.AutoSize = true;
            this.informationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLbl.Location = new System.Drawing.Point(61, 61);
            this.informationLbl.Name = "informationLbl";
            this.informationLbl.Size = new System.Drawing.Size(190, 16);
            this.informationLbl.TabIndex = 11;
            this.informationLbl.Text = "PATIENTS INFORMATION";
            this.informationLbl.Click += new System.EventHandler(this.informationLbl_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(205, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(410, 24);
            this.title.TabIndex = 12;
            this.title.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            this.title.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultsLbl
            // 
            this.resultsLbl.AutoSize = true;
            this.resultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLbl.Location = new System.Drawing.Point(53, 287);
            this.resultsLbl.Name = "resultsLbl";
            this.resultsLbl.Size = new System.Drawing.Size(124, 16);
            this.resultsLbl.TabIndex = 13;
            this.resultsLbl.Text = "QUEUE RESULT";
            this.resultsLbl.Click += new System.EventHandler(this.resultsLbl_Click);
            // 
            // queueNumberLbl
            // 
            this.queueNumberLbl.AutoSize = true;
            this.queueNumberLbl.Location = new System.Drawing.Point(56, 318);
            this.queueNumberLbl.Name = "queueNumberLbl";
            this.queueNumberLbl.Size = new System.Drawing.Size(76, 13);
            this.queueNumberLbl.TabIndex = 14;
            this.queueNumberLbl.Text = "Queu Number:";
            this.queueNumberLbl.Click += new System.EventHandler(this.queueNumberLbl_Click);
            // 
            // patientTypeLbl
            // 
            this.patientTypeLbl.AutoSize = true;
            this.patientTypeLbl.Location = new System.Drawing.Point(56, 340);
            this.patientTypeLbl.Name = "patientTypeLbl";
            this.patientTypeLbl.Size = new System.Drawing.Size(70, 13);
            this.patientTypeLbl.TabIndex = 15;
            this.patientTypeLbl.Text = "Patient Type:";
            this.patientTypeLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Location = new System.Drawing.Point(56, 364);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(41, 13);
            this.PriorityLbl.TabIndex = 16;
            this.PriorityLbl.Text = "Priority:";
            this.PriorityLbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PriorityLbl);
            this.Controls.Add(this.patientTypeLbl);
            this.Controls.Add(this.queueNumberLbl);
            this.Controls.Add(this.resultsLbl);
            this.Controls.Add(this.title);
            this.Controls.Add(this.informationLbl);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addToQueue);
            this.Controls.Add(this.patientType);
            this.Controls.Add(this.reasonForVisit);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.type);
            this.Controls.Add(this.patientsAge);
            this.Controls.Add(this.age);
            this.Controls.Add(this.patientsName);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox patientsName;
        private System.Windows.Forms.TextBox patientsAge;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox reasonForVisit;
        private System.Windows.Forms.Label reason;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox patientType;
        private System.Windows.Forms.Button addToQueue;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label informationLbl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label resultsLbl;
        private System.Windows.Forms.Label queueNumberLbl;
        private System.Windows.Forms.Label patientTypeLbl;
        private System.Windows.Forms.Label PriorityLbl;
    }
}

