using System;
using System.Windows.Forms;

namespace GPACalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtStudentCount = new TextBox();
            txtGPAX = new TextBox();
            txtMinScore = new TextBox();
            txtMaxScore = new TextBox();
            lblTotalStudents = new Label();
            lblGPAX = new Label();
            lblMinGPA = new Label();
            lblMaxGPA = new Label();
            btnSubmitScore = new Button();
            txtInputScore = new TextBox();
            lblHeader = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtStudentCount
            // 
            txtStudentCount.Location = new Point(150, 234);
            txtStudentCount.Name = "txtStudentCount";
            txtStudentCount.ReadOnly = true;
            txtStudentCount.Size = new Size(100, 27);
            txtStudentCount.TabIndex = 11;
            // 
            // txtGPAX
            // 
            txtGPAX.Location = new Point(150, 204);
            txtGPAX.Name = "txtGPAX";
            txtGPAX.ReadOnly = true;
            txtGPAX.Size = new Size(100, 27);
            txtGPAX.TabIndex = 10;
            // 
            // txtMinScore
            // 
            txtMinScore.Location = new Point(150, 174);
            txtMinScore.Name = "txtMinScore";
            txtMinScore.ReadOnly = true;
            txtMinScore.Size = new Size(100, 27);
            txtMinScore.TabIndex = 9;
            // 
            // txtMaxScore
            // 
            txtMaxScore.Location = new Point(150, 144);
            txtMaxScore.Name = "txtMaxScore";
            txtMaxScore.ReadOnly = true;
            txtMaxScore.Size = new Size(100, 27);
            txtMaxScore.TabIndex = 8;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Location = new Point(44, 237);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(100, 23);
            lblTotalStudents.TabIndex = 7;
            lblTotalStudents.Text = "จำนวนคน  :";
            // 
            // lblGPAX
            // 
            lblGPAX.Location = new Point(57, 207);
            lblGPAX.Name = "lblGPAX";
            lblGPAX.Size = new Size(57, 23);
            lblGPAX.TabIndex = 6;
            lblGPAX.Text = "GPAX  :";
            // 
            // lblMinGPA
            // 
            lblMinGPA.Location = new Point(30, 177);
            lblMinGPA.Name = "lblMinGPA";
            lblMinGPA.Size = new Size(100, 23);
            lblMinGPA.TabIndex = 5;
            lblMinGPA.Text = "คะแนนต่ำสุด  :";
            // 
            // lblMaxGPA
            // 
            lblMaxGPA.Location = new Point(31, 148);
            lblMaxGPA.Name = "lblMaxGPA";
            lblMaxGPA.Size = new Size(100, 23);
            lblMaxGPA.TabIndex = 4;
            lblMaxGPA.Text = "คะแนนสูงสุด  :";
            // 
            // btnSubmitScore
            // 
            btnSubmitScore.Location = new Point(154, 321);
            btnSubmitScore.Name = "btnSubmitScore";
            btnSubmitScore.Size = new Size(254, 29);
            btnSubmitScore.TabIndex = 2;
            btnSubmitScore.Text = "เพิ่มคะแนน";
            btnSubmitScore.Click += AddScore_Click;
            // 
            // txtInputScore
            // 
            txtInputScore.Location = new Point(150, 30);
            txtInputScore.Name = "txtInputScore";
            txtInputScore.Size = new Size(100, 27);
            txtInputScore.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(17, 33);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(103, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ใส่เกรดของคุณ :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblMaxGPA);
            groupBox1.Controls.Add(lblMinGPA);
            groupBox1.Controls.Add(lblGPAX);
            groupBox1.Controls.Add(lblTotalStudents);
            groupBox1.Controls.Add(txtMaxScore);
            groupBox1.Controls.Add(txtMinScore);
            groupBox1.Controls.Add(txtGPAX);
            groupBox1.Controls.Add(txtStudentCount);
            groupBox1.Location = new Point(85, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "ตรวจสอบเกรด";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(85, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblHeader);
            groupBox3.Controls.Add(txtInputScore);
            groupBox3.Location = new Point(85, 97);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(386, 68);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(748, 439);
            Controls.Add(groupBox3);
            Controls.Add(btnSubmitScore);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "เช็คเกรด";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtStudentCount;
        private TextBox txtGPAX;
        private TextBox txtMinScore;
        private TextBox txtMaxScore;
        private Label lblTotalStudents;
        private Label lblGPAX;
        private Label lblMinGPA;
        private Label lblMaxGPA;
        private Button btnSubmitScore;
        private TextBox txtInputScore;
        private Label lblHeader;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
    }
}
