using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolomkaProgrammVersion2
{
    public partial class WorkKlientForm : Form
    {
        static public bool Str10 = true;
        static public bool Str20 = false;
        static public bool Str30 = false;
        static public bool StrAll = false;
        static public int RowsCount = 0;
        public WorkKlientForm()
        {
            InitializeComponent();
            timer1.Enabled = false;
            ClassClient.SelectClient(0, 10);
            #region
            SelectClientDg.DataSource = ClassClient.DtClient;
            PreviousBtn.MouseMove += (s,e) =>
            {
                if (PreviousBtn.Size.Height >= 10 & PreviousBtn.Size.Height <= 36)
                {
                    PreviousBtn.Size = new Size(141, PreviousBtn.Size.Height + 2);
                }
            };
            PreviousBtn.MouseLeave += (s, e) =>
            {
                PreviousBtn.Size = new Size(141, PreviousBtn.Size.Height - PreviousBtn.Size.Height + 10);
            };
            NextBtn.MouseMove += (s, e) =>
            {
                if (NextBtn.Size.Height >= 10 & NextBtn.Size.Height <= 36)
                {
                    NextBtn.Size = new Size(141, NextBtn.Size.Height + 2);
                }
            };
            NextBtn.MouseLeave += (s, e) =>
            {
                NextBtn.Size = new Size(141, NextBtn.Size.Height - NextBtn.Size.Height + 10);
            };
            Select10strBtn.MouseMove += (s, e) =>
            {
                if (Select10strBtn.Size.Width >= 10 & Select10strBtn.Size.Width <= 53)
                {
                    Select10strBtn.Size = new Size(Select10strBtn.Size.Width + 2, 50);
                }
            };
            Select10strBtn.MouseLeave += (s, e) =>
            {
                Select10strBtn.Size = new Size(Select10strBtn.Size.Height - Select10strBtn.Size.Height + 10, 50);
            };
            Select20strBtn.MouseMove += (s, e) =>
            {
                if (Select20strBtn.Size.Width >= 10 & Select20strBtn.Size.Width <= 53)
                {
                    Select20strBtn.Size = new Size(Select20strBtn.Size.Width + 2, 50);
                }
            };
            Select20strBtn.MouseLeave += (s, e) =>
            {
                Select20strBtn.Size = new Size(Select20strBtn.Size.Height - Select20strBtn.Size.Height + 10, 50);
            };
            Select30strBtn.MouseMove += (s, e) =>
            {
                if (Select30strBtn.Size.Width >= 10 & Select30strBtn.Size.Width <= 53)
                {
                    Select30strBtn.Size = new Size(Select30strBtn.Size.Width + 2, 50);
                }
            };
            Select30strBtn.MouseLeave += (s, e) =>
            {
                Select30strBtn.Size = new Size(Select30strBtn.Size.Height - Select30strBtn.Size.Height + 10, 50);
            };
            SelectAllstrBtn.MouseMove += (s, e) =>
            {
                if (SelectAllstrBtn.Size.Width >= 10 & SelectAllstrBtn.Size.Width <= 53)
                {
                    SelectAllstrBtn.Size = new Size(SelectAllstrBtn.Size.Width + 2, 50);
                }
            };
            SelectAllstrBtn.MouseLeave += (s, e) =>
            {
                SelectAllstrBtn.Size = new Size(SelectAllstrBtn.Size.Height - SelectAllstrBtn.Size.Height + 10, 50);
            };
            #endregion
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (SelectClientDg.RowCount != 0)
            {
                if (Str10 == true)
                {
                    if (SelectClientDg.RowCount >= 10)
                    {
                        if (RowsCount + 10 != ClassClient.SelectRowsCount())
                        {
                            ClassClient.SelectClient(RowsCount + 10, 10);
                            SelectClientDg.DataSource = ClassClient.DtClient;
                            RowsCount += 10;
                        }
                    }
                }
                else if (Str20 == true)
                {
                    if (SelectClientDg.RowCount >= 20)
                    {
                        if (RowsCount + 20 != ClassClient.SelectRowsCount())
                        {
                            ClassClient.SelectClient(RowsCount + 20, 20);
                            SelectClientDg.DataSource = ClassClient.DtClient;
                            RowsCount += 20;
                        }
                    }
                }
                else if (Str30 == true)
                {
                    if (SelectClientDg.RowCount >= 30)
                    {
                        if (RowsCount + 30 != ClassClient.SelectRowsCount())
                        {
                            ClassClient.SelectClient(RowsCount + 30, 30);
                            SelectClientDg.DataSource = ClassClient.DtClient;
                            RowsCount += 30;
                        }
                    }
                }
            }
        }
        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (SelectClientDg.RowCount != 0)
            {
                if (Str10 == true)
                {
                    if (RowsCount > 0)
                    {
                        ClassClient.SelectClient(RowsCount - 10, 10);
                        SelectClientDg.DataSource = ClassClient.DtClient;
                        RowsCount -= 10;
                    }
                }
                else if (Str20 == true)
                {
                    if (RowsCount > 0)
                    {
                        ClassClient.SelectClient(RowsCount - 20, 20);
                        SelectClientDg.DataSource = ClassClient.DtClient;
                        RowsCount -= 20;
                    }
                }
                else if (Str30 == true)
                {
                    if (RowsCount > 0)
                    {
                        ClassClient.SelectClient(RowsCount - 30, 30);
                        SelectClientDg.DataSource = ClassClient.DtClient;
                        RowsCount -= 30;
                    }
                }
            }
        }
        private void Select10strBtn_Click(object sender, EventArgs e)
        {
            Str10 = true;
            Str20 = false;
            Str30 = false;
            StrAll = false;
            RowsCount = 0;
            ClassClient.SelectClient(0, 10);
            SelectClientDg.DataSource = ClassClient.DtClient;
        }
        private void Select20strBtn_Click(object sender, EventArgs e)
        {
            Str10 = false;
            Str20 = true;
            Str30 = false;
            StrAll = false;
            RowsCount = 0;
            ClassClient.SelectClient(0, 20);
            SelectClientDg.DataSource = ClassClient.DtClient;
        }
        private void Select30strBtn_Click(object sender, EventArgs e)
        {
            Str10 = false;
            Str20 = false;
            Str30 = true;
            StrAll = false;
            RowsCount = 0;
            ClassClient.SelectClient(0, 30);
            SelectClientDg.DataSource = ClassClient.DtClient;
        }
        private void SelectAllstrBtn_Click(object sender, EventArgs e)
        {
            Str10 = false;
            Str20 = false;
            Str30 = false;
            StrAll = true;
            RowsCount = 0;
            ClassClient.SelectClient(0, ClassClient.SelectRowsCount());
            SelectClientDg.DataSource = ClassClient.DtClient;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            if (Str10 == true)
                i = 10 + RowsCount;
            if (Str20 == true)
                i = 20 + RowsCount;
            if (Str30 == true)
                i = 30 + RowsCount;
            if (StrAll == true)
                i = ClassClient.SelectRowsCount();
            if (i > ClassClient.SelectRowsCount())
            {
                int itog = i - ClassClient.SelectRowsCount();
                i -= itog;
            }
            label1.Text = i.ToString();
            label3.Text = Convert.ToString(ClassClient.SelectRowsCount());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RedForm red = new RedForm(SelectClientDg.CurrentRow.Cells[0].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[1].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[2].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[3].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[4].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[6].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[7].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[8].Value.ToString(),
                SelectClientDg.CurrentRow.Cells[9].Value.ToString()
                );
            red.ShowDialog();
        }

        private void DeleteClientBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы точно хотите удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (ClassClient.DeleteClient(SelectClientDg.CurrentRow.Cells[0].Value.ToString()) == true)
                {
                    if (Str10 == true)
                    {
                        ClassClient.SelectClient(RowsCount, 10);
                    }
                    else if (Str20 == true)
                    {
                        ClassClient.SelectClient(RowsCount, 20);
                    }
                    else if (Str30 == true)
                    {

                        ClassClient.SelectClient(RowsCount, 30);
                    }
                }
                else if (ClassClient.DeleteClient(SelectClientDg.CurrentRow.Cells[0].Value.ToString()) == false)
                {
                    MessageBox.Show("Неудалось удалить запись, клиент имеет посещения", "Ошибка");
                }
            }
        }

        private void SelectClientBirthdayBtn_Click(object sender, EventArgs e)
        {
            if (SelectClientBirthdayBtn.Text.Contains("Показать клиентов у котороых день рождения в этом месяце"))
            {
                ClassClient.SelectBirthdayClient();
                SelectClientDg.DataSource = ClassClient.DtClientBirthday;
                SelectClientBirthdayBtn.Text = SelectClientBirthdayBtn.Text.Replace("Показать клиентов у котороых день рождения в этом месяце", "Отмена");
            }
            else
            {
                if (Str10 == true)
                {
                    ClassClient.SelectClient(RowsCount, 10);
                    SelectClientDg.DataSource = ClassClient.DtClient;
                }
                else if (Str20 == true)
                {
                    ClassClient.SelectClient(RowsCount, 20);
                    SelectClientDg.DataSource = ClassClient.DtClient;
                }
                else if (Str30 == true)
                {
                    ClassClient.SelectClient(RowsCount, 30);
                    SelectClientDg.DataSource = ClassClient.DtClient;
                }
                SelectClientBirthdayBtn.Text = SelectClientBirthdayBtn.Text.Replace("Отмена", "Показать клиентов у котороых день рождения в этом месяце");
                if (SelectClientDg.RowCount == 0)
                {
                    ClassClient.SelectClient(0, 10);
                    SelectClientDg.DataSource = ClassClient.DtClient;
                }
            }
        }

        async private void OtborSearhBtn_Click(object sender, EventArgs e)
        {
            if (SearchNameTx.Visible == true & SearchFamTx.Visible == true
                    & SearchOtchTx.Visible == true & SearchMailTx.Visible == true
                    & SearchTelephoneTx.Visible == true)
            {
                await Task.Delay(100);
                SearchNameTx.Visible = false;
                SearchFamTx.Visible = false;
                SearchOtchTx.Visible = false;
                SearchMailTx.Visible = false;
                SearchTelephoneTx.Visible = false;
                OtborGenderCb.Visible = false;
            }
            else
            {
                await Task.Delay(100);
                SearchNameTx.Visible = true;
                SearchFamTx.Visible = true;
                SearchOtchTx.Visible = true;
                SearchMailTx.Visible = true;
                OtborGenderCb.Visible = true;
                SearchTelephoneTx.Visible = true;
            }
        }

        private void OtborGenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OtborGenderCb.SelectedIndex == 0)
            {
                ClassClient.OtborMenWoman("1");
                SelectClientDg.DataSource = ClassClient.DtOtborMenWoman;
            }
            else if (OtborGenderCb.SelectedIndex == 1)
            {
                ClassClient.OtborMenWoman("2");
                SelectClientDg.DataSource = ClassClient.DtOtborMenWoman;
            }
            else if (OtborGenderCb.SelectedIndex == 2)
            {
                if (Str10 == true)
                {
                    ClassClient.SelectClient(RowsCount, 10);
                    SelectClientDg.DataSource = ClassClient.DtClient;
                }
                else if (Str20 == true)
                {
                    ClassClient.SelectClient(RowsCount, 20);
                    SelectClientDg.DataSource = ClassClient.DtClient;
                }
                else if (Str30 == true)
                {

                    ClassClient.SelectClient(RowsCount, 30);
                    SelectClientDg.DataSource = ClassClient.DtClient;
                }
            }
        }

        private void SearchNameTx_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectClientDg.RowCount; i++)
            {
                if (SelectClientDg[1, i].FormattedValue.ToString().Contains(SearchNameTx.Text.Trim()))
                {
                    SelectClientDg.CurrentCell = SelectClientDg[1, i];
                    return;
                }
            }
        }

        private void SearchFamTx_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectClientDg.RowCount; i++)
            {
                if (SelectClientDg[2, i].FormattedValue.ToString().Contains(SearchFamTx.Text.Trim()))
                {
                    SelectClientDg.CurrentCell = SelectClientDg[2, i];
                    return;
                }
            }
        }

        private void SearchOtchTx_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectClientDg.RowCount; i++)
            {
                if (SelectClientDg[3, i].FormattedValue.ToString().Contains(SearchOtchTx.Text.Trim()))
                {
                    SelectClientDg.CurrentCell = SelectClientDg[3, i];
                    return;
                }
            }
        }

        private void SearchMailTx_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectClientDg.RowCount; i++)
            {
                if (SelectClientDg[6, i].FormattedValue.ToString().Contains(SearchMailTx.Text.Trim()))
                {
                    SelectClientDg.CurrentCell = SelectClientDg[6, i];
                    return;
                }
            }
        }

        private void SearchTelephoneTx_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectClientDg.RowCount; i++)
            {
                if (SelectClientDg[7, i].FormattedValue.ToString().Contains(SearchTelephoneTx.Text.Trim()))
                {
                    SelectClientDg.CurrentCell = SelectClientDg[7, i];
                    return;
                }
            }
        }

        private void SelectClientDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassClient.SelectTeg(SelectClientDg.CurrentRow.Cells[0].Value.ToString());
            SelectTegDg.DataSource = ClassClient.DtSelectTeg;
            string MassiveColor = "";
            if (SelectTegDg.RowCount != 0)
            {
                for (int i = 0; i < SelectTegDg.RowCount; i++)
                {
                    MassiveColor = SelectTegDg["Column12", i].Value.ToString();
                    string[] ColorArg = MassiveColor.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    SelectTegDg["Column11", i].Style.BackColor = Color.FromArgb(Convert.ToInt32(ColorArg[0]), Convert.ToInt32(ColorArg[1]), Convert.ToInt32(ColorArg[2]));
                    SelectTegDg.CurrentCell = null;
                }
            }
        }

        private void SortNameBtn_Click(object sender, EventArgs e)
        {
            if (Str10 == true)
            {
                ClassClient.SortName(RowsCount, 10);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
            else if (Str20 == true)
            {
                ClassClient.SortName(RowsCount, 20);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
            else if (Str30 == true)
            {
                ClassClient.SortName(RowsCount, 30);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
        }

        private void SortFamBtn_Click(object sender, EventArgs e)
        {
            if (Str10 == true)
            {
                ClassClient.SortFam(RowsCount, 10);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
            else if (Str20 == true)
            {
                ClassClient.SortFam(RowsCount, 20);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
            else if (Str30 == true)
            {
                ClassClient.SortFam(RowsCount, 30);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
        }

        private void SortOtchBtn_Click(object sender, EventArgs e)
        {
            if (Str10 == true)
            {
                ClassClient.SortOtch(RowsCount, 10);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
            else if (Str20 == true)
            {
                ClassClient.SortOtch(RowsCount, 20);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
            else if (Str30 == true)
            {
                ClassClient.SortOtch(RowsCount, 30);
                SelectClientDg.DataSource = ClassClient.DtSortClientName;
            }
        }
        private void WorkKlientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
