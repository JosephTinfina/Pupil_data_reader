namespace Pupil_data_reader
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPupilData = new DataGridView();
            tvSubjects = new TreeView();
            ((System.ComponentModel.ISupportInitialize)dgvPupilData).BeginInit();
            SuspendLayout();
            // 
            // dgvPupilData
            // 
            dgvPupilData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPupilData.Location = new Point(598, 106);
            dgvPupilData.Name = "dgvPupilData";
            dgvPupilData.RowHeadersWidth = 123;
            dgvPupilData.Size = new Size(2131, 1110);
            dgvPupilData.TabIndex = 0;
            dgvPupilData.CellContentClick += dgvPupilData_CellContentClick;
            // 
            // tvSubjects
            // 
            tvSubjects.Location = new Point(111, 120);
            tvSubjects.Name = "tvSubjects";
            tvSubjects.Size = new Size(447, 476);
            tvSubjects.TabIndex = 1;
            tvSubjects.AfterSelect += tvSubjects_AfterSelect;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2221, 861);
            Controls.Add(tvSubjects);
            Controls.Add(dgvPupilData);
            Name = "frmMain";
            Text = "Pupil Data";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPupilData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPupilData;
        private TreeView tvSubjects;
    }
}
