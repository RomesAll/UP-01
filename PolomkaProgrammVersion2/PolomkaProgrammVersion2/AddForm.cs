using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolomkaProgrammVersion2
{
    public partial class AddForm : Form
    {
        static public bool itog = false;
        static public string FileName = "";
        static public string FileNamePyth = "";
        static public char Sobaka = '-';
        static public char Tochka = '-';
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddPhotoBtn_Click(object sender, EventArgs e)
        {
            Bitmap file1;
            OpenFileDialog opnefile = new OpenFileDialog();
            opnefile.InitialDirectory = @"\Клиенты\";

            if (opnefile.ShowDialog() == DialogResult.OK)
            {
                var size = new FileInfo(opnefile.FileName).Length;
                FileNamePyth = opnefile.FileName;
                FileNamePyth = FileNamePyth.Replace("\\", "/");
                FileName = Path.GetFileName(opnefile.FileName);
                if (size <= 2097152)
                {
                    file1 = new Bitmap(opnefile.FileName);
                    pictureBox1.Image = file1;
                    pictureBox1.Invalidate();
                }
                else
                    MessageBox.Show("Изображение превышает 2мб");
            }
        }
        private bool ProverkaFio()
        {
            if (FioTx.Text == "" || NamTx.Text == "" || OtchTx.Text == "")
            {
                label5.Text = "X";
                label5.ForeColor = Color.Red;
                if (FioTx.Text == "")
                    label11.Visible = true;
                if (NamTx.Text == "")
                    label12.Visible = true;
                if (OtchTx.Text == "")
                    label13.Visible = true;
                return false;
            }
            else
            {
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label5.Text = "V";
                label5.ForeColor = Color.Green;
                return true;
            }
        }
        private bool ProverkaEmail()
        {
            int i = 0;
            int count1 = 0;
            int count2 = 0;
            string email = EmailTx.Text;

            while (i < email.Length)
            {
                if (email[i] == '@')
                    count1++;
                if (email[i] == '.')
                    count2++;
                i++;
            }
            if (EmailTx.Text != "")
            {
                string Email = EmailTx.Text;

                for (i = 0; i < Email.Length; i++)
                {
                    if (Email[i] == '@')
                    {
                        Sobaka = Email[i];
                    }
                    if (Email[i] == '.')
                    {
                        Tochka = Email[i];
                    }
                }
                if (Sobaka == '@' & Tochka == '.')
                {
                    if (count1 == 1 & count2 == 1)
                    {
                        int countSobaka = email.IndexOf("@");
                        int countTochka = email.IndexOf(".");
                        if (countSobaka < countTochka)
                        {
                            string[] mae = new string[countSobaka];
                            string[] mae2 = new string[countTochka];
                            for (int i1 = 0; i1 < mae.Length; i1++)
                            {
                                mae[i1] = Convert.ToString(email[i1]);
                            }
                            if (mae.Length > 0)
                            {
                                for (int i1 = 0; i1 < mae2.Length; i1++)
                                {
                                    mae2[i1] = Convert.ToString(email[i1]);
                                }
                                if (countTochka - countSobaka > 1)
                                {
                                    if (email.Length - countTochka > 1)
                                    {
                                        label6.Text = "";
                                        return true;
                                    }
                                    else
                                        return false;
                                }
                                else
                                {
                                    label6.Text = "После символа <@> ничего нет";
                                    return false;
                                }
                            }
                            else
                            {
                                label6.Text = "Перед символом <@> ничего нет";
                                return false;
                            }
                        }
                        else
                        {
                            label6.Text = "Символ <.> стоит перед символом <@>";
                            return false;
                        }
                    }
                    else
                    {
                        label6.Text = "Вы ввели несколько символов <@> или <.> ";
                        return false;
                    }
                }
                else
                {
                    label6.Text = "Вы не ввели символ <@> или <.>";
                    return false;
                }
            }
            else
            {
                label6.Text = "Поле пустое";
                return false;
            }
        }
        private void AddClientBtn_Click(object sender, EventArgs e)
        {

            if (ProverkaFio() == true & ProverkaEmail() == true & TelephoneTx.Text != "" & FileName != "")
            {
                label8.Text = "";
                label6.Text = "";
                byte gender = 0;
                if (GenderCm.SelectedIndex == 0)
                {
                    gender = 1;
                }
                else if (GenderCm.SelectedIndex == 1)
                {
                    gender = 2;
                }
                DateTime dt = DateTime.Now;
                if (ClassClientAddRed.AddClient(FioTx.Text, NamTx.Text, OtchTx.Text, dateTimePicker1.Text, dt.ToString("yyyy.MM.dd"), EmailTx.Text, TelephoneTx.Text, Convert.ToString(gender), FileNamePyth) == true)
                {
                    MessageBox.Show("Клиент добавлен");
                    button1.Enabled = true;
                    button2.Enabled = true;
                    WorkTag();
                }
                else
                    MessageBox.Show("Неудалось добавит клиента");
                if (WorkKlientForm.Str10 == true)
                {
                    ClassClient.SelectClient(WorkKlientForm.RowsCount, 10);
                }
                else if (WorkKlientForm.Str20 == true)
                {
                    ClassClient.SelectClient(WorkKlientForm.RowsCount, 20);
                }
                else if (WorkKlientForm.Str30 == true)
                {

                    ClassClient.SelectClient(WorkKlientForm.RowsCount, 30);
                }
            }
            else if (GenderCm.SelectedIndex == -1)
            {
                label8.Text = "Введите пол";
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            ClassClientAddRed.SelectTegAll();
            dataGridView2.DataSource = ClassClientAddRed.DtTegAll;
            string MassiveColor = "";
            if (dataGridView2.RowCount != 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    MassiveColor = dataGridView2["dataGridViewTextBoxColumn3",i].Value.ToString();
                    string[] ColorArg = MassiveColor.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    dataGridView2["dataGridViewTextBoxColumn3", i].Style.BackColor = Color.FromArgb(Convert.ToInt32(ColorArg[0]), Convert.ToInt32(ColorArg[1]), Convert.ToInt32(ColorArg[2]));
                    dataGridView2.CurrentCell = null;
                }
            }
           
        }
        private void WorkTag()
        {
            ClassClientAddRed.SelectEndClient();
            ClassClientAddRed.SelectTeg(Convert.ToString(ClassClientAddRed.Nomer));
            dataGridView1.DataSource = ClassClientAddRed.DtTeg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassClientAddRed.SelectEndClient();
            ClassClientAddRed.InsertTeg(Convert.ToString(ClassClientAddRed.Nomer), dataGridView2.CurrentRow.Cells[0].Value.ToString());
            ClassClientAddRed.SelectTeg(Convert.ToString(ClassClientAddRed.Nomer));
            dataGridView1.DataSource = ClassClientAddRed.DtTeg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassClientAddRed.DeleteTag(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ClassClientAddRed.SelectTeg(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string MassiveColor = "";
            if (dataGridView1.RowCount != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    MassiveColor = dataGridView1["Column4", i].Value.ToString();
                    string[] ColorArg = MassiveColor.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    dataGridView1["Column3", i].Style.BackColor = Color.FromArgb(Convert.ToInt32(ColorArg[0]), Convert.ToInt32(ColorArg[1]), Convert.ToInt32(ColorArg[2]));
                    dataGridView1.CurrentCell = null;
                }
            }
        }
    }
}
