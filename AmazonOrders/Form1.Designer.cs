

namespace AmazonOrders
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
            this.DatePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.DatePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.LabelEndTime = new System.Windows.Forms.Label();
            this.LabelStartTime = new System.Windows.Forms.Label();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.listViewReports = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DatePickerStartTime
            // 
            this.DatePickerStartTime.Location = new System.Drawing.Point(33, 39);
            this.DatePickerStartTime.Name = "DatePickerStartTime";
            this.DatePickerStartTime.Size = new System.Drawing.Size(200, 20);
            this.DatePickerStartTime.TabIndex = 0;
            // 
            // DatePickerEndTime
            // 
            this.DatePickerEndTime.Location = new System.Drawing.Point(463, 39);
            this.DatePickerEndTime.Name = "DatePickerEndTime";
            this.DatePickerEndTime.Size = new System.Drawing.Size(200, 20);
            this.DatePickerEndTime.TabIndex = 1;
            // 
            // LabelEndTime
            // 
            this.LabelEndTime.AutoSize = true;
            this.LabelEndTime.Location = new System.Drawing.Point(540, 19);
            this.LabelEndTime.Name = "LabelEndTime";
            this.LabelEndTime.Size = new System.Drawing.Size(52, 13);
            this.LabelEndTime.TabIndex = 2;
            this.LabelEndTime.Text = "End Time";
            // 
            // LabelStartTime
            // 
            this.LabelStartTime.AutoSize = true;
            this.LabelStartTime.Location = new System.Drawing.Point(97, 19);
            this.LabelStartTime.Name = "LabelStartTime";
            this.LabelStartTime.Size = new System.Drawing.Size(55, 13);
            this.LabelStartTime.TabIndex = 4;
            this.LabelStartTime.Text = "Start Time";
            // 
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(243, 278);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(207, 38);
            this.ButtonExport.TabIndex = 7;
            this.ButtonExport.Text = "Export";
            this.ButtonExport.UseVisualStyleBackColor = true;
            // 
            // listViewReports
            // 
            this.listViewReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name});
            this.listViewReports.Location = new System.Drawing.Point(33, 84);
            this.listViewReports.Name = "listViewReports";
            this.listViewReports.Size = new System.Drawing.Size(630, 188);
            this.listViewReports.TabIndex = 8;
            this.listViewReports.UseCompatibleStateImageBehavior = false;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 328);
            this.Controls.Add(this.listViewReports);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.LabelStartTime);
            this.Controls.Add(this.LabelEndTime);
            this.Controls.Add(this.DatePickerEndTime);
            this.Controls.Add(this.DatePickerStartTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePickerStartTime;
        private System.Windows.Forms.DateTimePicker DatePickerEndTime;
        private System.Windows.Forms.Label LabelEndTime;
        private System.Windows.Forms.Label LabelStartTime;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.ListView listViewReports;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
    }
}

