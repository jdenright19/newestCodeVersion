namespace Form
{
    partial class AddDrop
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Drop_btn = new System.Windows.Forms.Button();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.lbl_submit = new System.Windows.Forms.Button();
            this.lbl_currentSchedule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_numOfSeats = new System.Windows.Forms.Label();
            this.lbl_credit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_courseName = new System.Windows.Forms.Label();
            this.lbl_courseNumber = new System.Windows.Forms.Label();
            this.tbl_courseSched = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_select = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbl_courseSched.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(162, 65);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(570, 466);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Courses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Drop_btn
            // 
            this.Drop_btn.Location = new System.Drawing.Point(354, 581);
            this.Drop_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Drop_btn.Name = "Drop_btn";
            this.Drop_btn.Size = new System.Drawing.Size(86, 31);
            this.Drop_btn.TabIndex = 5;
            this.Drop_btn.Text = "Drop";
            this.Drop_btn.UseVisualStyleBackColor = true;
            this.Drop_btn.Click += new System.EventHandler(this.Drop_btn_Click);
            // 
            // Back_Btn
            // 
            this.Back_Btn.Location = new System.Drawing.Point(74, 576);
            this.Back_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(86, 31);
            this.Back_Btn.TabIndex = 6;
            this.Back_Btn.Text = "Back";
            this.Back_Btn.UseVisualStyleBackColor = true;
            // 
            // lbl_submit
            // 
            this.lbl_submit.Location = new System.Drawing.Point(446, 583);
            this.lbl_submit.Name = "lbl_submit";
            this.lbl_submit.Size = new System.Drawing.Size(114, 27);
            this.lbl_submit.TabIndex = 11;
            this.lbl_submit.Text = "Submit";
            this.lbl_submit.UseVisualStyleBackColor = true;
            this.lbl_submit.Click += new System.EventHandler(this.lbl_submit_Click);
            // 
            // lbl_currentSchedule
            // 
            this.lbl_currentSchedule.AutoSize = true;
            this.lbl_currentSchedule.Location = new System.Drawing.Point(768, 41);
            this.lbl_currentSchedule.Name = "lbl_currentSchedule";
            this.lbl_currentSchedule.Size = new System.Drawing.Size(121, 20);
            this.lbl_currentSchedule.TabIndex = 10;
            this.lbl_currentSchedule.Text = "Current Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Start";
            // 
            // lbl_numOfSeats
            // 
            this.lbl_numOfSeats.AutoSize = true;
            this.lbl_numOfSeats.Location = new System.Drawing.Point(553, 0);
            this.lbl_numOfSeats.Name = "lbl_numOfSeats";
            this.lbl_numOfSeats.Size = new System.Drawing.Size(88, 40);
            this.lbl_numOfSeats.TabIndex = 4;
            this.lbl_numOfSeats.Text = "Number of Time Blocks";
            // 
            // lbl_credit
            // 
            this.lbl_credit.AutoSize = true;
            this.lbl_credit.Location = new System.Drawing.Point(471, 0);
            this.lbl_credit.Name = "lbl_credit";
            this.lbl_credit.Size = new System.Drawing.Size(67, 40);
            this.lbl_credit.TabIndex = 3;
            this.lbl_credit.Text = "Number of Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Credit";
            this.label5.UseWaitCursor = true;
            // 
            // lbl_courseName
            // 
            this.lbl_courseName.AutoSize = true;
            this.lbl_courseName.Location = new System.Drawing.Point(250, 0);
            this.lbl_courseName.Name = "lbl_courseName";
            this.lbl_courseName.Size = new System.Drawing.Size(71, 20);
            this.lbl_courseName.TabIndex = 1;
            this.lbl_courseName.Text = "Instructor";
            // 
            // lbl_courseNumber
            // 
            this.lbl_courseNumber.AutoSize = true;
            this.lbl_courseNumber.Location = new System.Drawing.Point(3, 0);
            this.lbl_courseNumber.Name = "lbl_courseNumber";
            this.lbl_courseNumber.Size = new System.Drawing.Size(63, 40);
            this.lbl_courseNumber.TabIndex = 0;
            this.lbl_courseNumber.Text = "Course Number";
            // 
            // tbl_courseSched
            // 
            this.tbl_courseSched.BackColor = System.Drawing.Color.MistyRose;
            this.tbl_courseSched.ColumnCount = 10;
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78199F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21801F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tbl_courseSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tbl_courseSched.Controls.Add(this.label10, 0, 0);
            this.tbl_courseSched.Controls.Add(this.lbl_courseNumber, 0, 0);
            this.tbl_courseSched.Controls.Add(this.lbl_courseName, 1, 0);
            this.tbl_courseSched.Controls.Add(this.label5, 2, 0);
            this.tbl_courseSched.Controls.Add(this.lbl_credit, 3, 0);
            this.tbl_courseSched.Controls.Add(this.lbl_numOfSeats, 4, 0);
            this.tbl_courseSched.Controls.Add(this.label4, 5, 0);
            this.tbl_courseSched.Controls.Add(this.label3, 6, 0);
            this.tbl_courseSched.Controls.Add(this.txt_select, 9, 0);
            this.tbl_courseSched.Controls.Add(this.label11, 8, 0);
            this.tbl_courseSched.Location = new System.Drawing.Point(768, 79);
            this.tbl_courseSched.Name = "tbl_courseSched";
            this.tbl_courseSched.RowCount = 1;
            this.tbl_courseSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_courseSched.Size = new System.Drawing.Size(1041, 447);
            this.tbl_courseSched.TabIndex = 9;
            this.tbl_courseSched.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_courseSched_Paint);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(91, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Days";
            // 
            // txt_select
            // 
            this.txt_select.AutoSize = true;
            this.txt_select.Location = new System.Drawing.Point(932, 0);
            this.txt_select.Name = "txt_select";
            this.txt_select.Size = new System.Drawing.Size(49, 20);
            this.txt_select.TabIndex = 8;
            this.txt_select.Text = "Select";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(841, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Time End";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-148, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Course Name";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78199F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21801F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Course Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-148, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Course Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1906, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 649);
            this.Controls.Add(this.lbl_submit);
            this.Controls.Add(this.lbl_currentSchedule);
            this.Controls.Add(this.tbl_courseSched);
            this.Controls.Add(this.Back_Btn);
            this.Controls.Add(this.Drop_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddDrop";
            this.Text = "AddDrop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbl_courseSched.ResumeLayout(false);
            this.tbl_courseSched.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private Button Drop_btn;
        private Button Back_Btn;
        private Button lbl_submit;
        private Label lbl_currentSchedule;
        private Label lbl_time;
        private Label label3;
        private Label lbl_numOfSeats;
        private Label lbl_credit;
        private Label label5;
        private Label lbl_courseName;
        private Label lbl_courseNumber;
        private TableLayoutPanel tbl_courseSched;
        private Label txt_select;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label9;
        private MenuStrip menuStrip1;
        private Label label10;
        private Label label11;
        private EventHandler label10_Click;
    }
}