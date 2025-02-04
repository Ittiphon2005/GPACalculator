using System;
using System.Windows.Forms;

namespace GPACalculatorApp
{
    public partial class Form1 : Form
    {
        private List<double> scores = new List<double>(); // เก็บคะแนน

        public Form1()
        {
            InitializeComponent();
        }

        // เพิ่มคะแนนและอัปเดตข้อมูลเกรด
        private void AddScore(double score)
        {
            scores.Add(score);
            UpdateGradeInfo();
        }

        // อัปเดตข้อมูลเกรดหลังจากเพิ่มคะแนน
        private void UpdateGradeInfo()
        {
            if (scores.Count == 0)
            {
                txtMaxScore.Text = "";
                txtMinScore.Text = "";
                txtGPAX.Text = "";
                txtStudentCount.Text = "";
                return;
            }

            double maxScore = scores.Max();
            double minScore = scores.Min();
            double gpax = scores.Average();
            int studentCount = scores.Count;

            txtMaxScore.Text = maxScore.ToString("0.00");
            txtMinScore.Text = minScore.ToString("0.00");
            txtGPAX.Text = gpax.ToString("0.00");
            txtStudentCount.Text = studentCount.ToString();
        }

        private void AddScore_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInputScore.Text, out double score))
            {
                AddScore(score);
                txtInputScore.Clear();
            }
            else
            {
                MessageBox.Show("กรุณากรอกตัวเลขที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}