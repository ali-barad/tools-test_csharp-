using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Datetime İşlemleri
// Tarih Formatları
// Datetime picker
// Month Calendar
// OpenfileDialog
// Trackbar
//numericUpDown 
//TreeView
namespace test_csharp_tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        //Datetime İşlemleri
        // Tarih Formatları
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString(); //عند الضغط على بوتن اظهار   قم باظهار  التاريخ الوقت بصندوق التول بوكس  
        }
        // Datetime picker
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.AddMinutes(3).ToString();          //      وعر اضافة على الدقائق 3 دقائق
            textBox2.Text = DateTime.Now.AddHours(3).ToString();            //       اضافة على الساعة 3 ساعات 
            textBox2.Text = DateTime.Now.AddMonths(3).ToString();           // اضافة على الاشهر  3 اشهر 
            textBox2.Text = DateTime.Now.AddYears(3).ToString();            // اضافة على السنوات  3 سنوات 

            // يقوم البرنامج بتفيذ اخر سطر اي اضافة السنوات فقط  
        }

        //monthCalendar
        private void button3_Click(object sender, EventArgs e)
        {
            if (!monthCalendar1.Visible)  // اذا كان التقويم موجود على الشاشة وتم الضغط على البوتن قم باخفاء التقويم  

            {
                monthCalendar1.Visible = true;
                button3.Text = "اخفاء ";  // تحويل نص البوتون الى اخفاء
            }
            else
            {
                monthCalendar1.Visible = false; // اذا كان التقويم  غير موجود على الشاشة وتم الضغط على البوتن باظهار  التقويم
                button3.Text = "اظهار";  //تحويل نص البوتون اظهار 
            }
        }


        //monthCalendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime d = monthCalendar1.SelectionRange.Start;
            DateTime d1 = monthCalendar1.SelectionRange.Start;

            label9.Text = d.ToString() + "\n" + d1.ToString();
        }
        // OpenfileDialog
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();  // قمنا باخذ متغير اسمها فايل 
            file.Filter = "Resim Dosyalari (jpg, png) |*.jpg; *.png";  //  قمنا بتحديد الصيغ التي يمكن استخدامها  
            file.Title = "new file "; // قمنا باضافة اسم للفورم 




            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;    //اظهار اسم الملف 
                string DosyaAdi = file.SafeFileName;   //اظهار اسم  عنوان الملف 


                MessageBox.Show(DosyaAdi + "---" + DosyaYolu); //  اظهار اسم الملف **  اظهار اسم  عنوان الملف بمسج بوكس
                pictureBox1.BackgroundImage = Image.FromFile(DosyaYolu); //اختيار الصورة 
                pictureBox1.BackgroundImage = new Bitmap(DosyaYolu); //اظهار الصورة  

            }

        }

        // Trackbar
        private void button5_Click(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            textBox4.Text = value.ToString();   // اظهار قمية الفاليو باتكست بوكس 4 

            if (trackBar1.Value == 0 && trackBar1.Value < 5)  // اختيار اللون  اذا كان القيمة بتساوي  0 او اضغر من 5 
            {
                this.BackColor = Color.Red; // اطبع اللون الاحمر 
            }

            else if (trackBar1.Value > 5 && trackBar1.Value < 10) // اختيار اللون  اذا كان القيمةاكبر  5 او اضغر من 10 
            {
                this.BackColor = Color.Blue; // اطبع اللون الازرق
            }
        }

        //TreeView
        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown1.Increment = 2;  // زيادة 2 على القيمة 
                                           //    numericUpDown1.Value =100;    // عند الضغط على البوتون يقوم باظهار 100 في صندوق 
            numericUpDown1.TextAlign = HorizontalAlignment.Center; // اظهار الرقم في الصندوق في النصف 

            textBox5.Text = numericUpDown1.Value.ToString(); // اظهار القيمة في ال تيكست بوكس 

        }

        //addRoot //addchild
        private void button7_Click(object sender, EventArgs e)
        {
            TreeNode secilen = treeView1.SelectedNode;

            if (radioButton1.Checked == true)
            {
                treeView1.Nodes.Add(textBox6.Text);
            }
            else if (radioButton2.Checked == true)
            {
                secilen.Nodes.Add(comboBox1.Text);
            }
        }
        // عرض جميع القوائم في تري فيو 
        private void button9_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        // خروج من التطبيق 
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // حذف جميع النودات 
        private void button8_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();// حذف جميع النودات 

        }
    }

}
