using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolomkaProgrammVersion2
{
    class ClassClient : ClassConnect
    {
        #region
        //static public DataTable DtClientLoad = new DataTable();
        //static public DataTable DtClientBetween = new DataTable();
        //static public DataTable DtOtborMenWoman = new DataTable();
        //static public DataTable DtSelectTeg = new DataTable();
        //static public DataTable DtSortClientName = new DataTable();

        //static public object CountTagofclientRows;
        //static public object CountClientIDRows;
        //static public void SelectClientLoad(int start)
        //{
        //    try
        //    {
        //        MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code ORDER BY client.ID LIMIT {start}";
        //        DtClientLoad.Clear();
        //        MyData.Fill(DtClientLoad);
        //    }
        //    catch
        //    {
        //        System.Windows.Forms.MessageBox.Show("Ошибка в запросе, неудалось вывести таблицу с клиентами", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        //    }
        //}
        //static public void SelectClientBetween(int start, int finish)
        //{
        //    MyCommand.CommandText = $"SELECT COUNT(*) AS count FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID BETWEEN {start} AND {finish} ORDER BY client.ID";
        //    CountClientIDRows = MyCommand.ExecuteScalar();
        //    if (Convert.ToInt32(CountClientIDRows) > 0)
        //    {
        //        MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID BETWEEN {start} AND {finish} ORDER BY client.ID";
        //        DtClientBetween.Clear();
        //        MyData.Fill(DtClientBetween);
        //    }
        //}
        //static public void SelectTeg(string nomer)
        //{
        //    MyCommand.CommandText = $"SELECT tag.ID, tag.Title, tag.Color FROM tagofclient, tag WHERE tagofclient.ClientID = '{nomer}' AND tagofclient.TagID = tag.ID";
        //    DtSelectTeg.Clear();
        //    MyData.Fill(DtSelectTeg);
        //}
        //static public void OtborMenWoman(string nomer)
        //{
        //    MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND gender.Code = '{nomer}' ORDER BY client.ID";
        //    DtOtborMenWoman.Clear();
        //    MyData.Fill(DtOtborMenWoman);
        //}
        //static public void SelectCountIDCount()
        //{
        //    MyCommand.CommandText = $"SELECT COUNT(*) AS count FROM client";
        //    CountTagofclientRows = MyCommand.ExecuteScalar();
        //}
        //static public void SelectCountID()
        //{
        //    MyCommand.CommandText = $"SELECT ID FROM client ORDER BY ID DESC LIMIT 1";
        //    CountClientIDRows = MyCommand.ExecuteScalar();
        //}
        //static public void SelectBirthdayClient()
        //{
        //    DateTime Birthday = DateTime.Now;
        //    MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.Birthday LIKE '%{Birthday.ToString("MM-dd")}%'";
        //    DtClientBirthday.Clear();
        //    MyData.Fill(DtClientBirthday);
        //}
        //static public void SortName(int start, int finish)
        //{
        //    MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID BETWEEN {start} AND {finish} ORDER BY client.FirstName ASC";
        //    DtSortClientName.Clear();
        //    MyData.Fill(DtSortClientName);
        //}
        //static public void SortFam(int start, int finish)
        //{
        //    MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID BETWEEN {start} AND {finish} ORDER BY client.LastName ASC";
        //    DtSortClientName.Clear();
        //    MyData.Fill(DtSortClientName);
        //}
        //static public void SortOtch(int start, int finish)
        //{
        //    MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID BETWEEN {start} AND {finish} ORDER BY client.Patronymic ASC";
        //    DtSortClientName.Clear();
        //    MyData.Fill(DtSortClientName);
        //}

        #endregion
        static public DataTable DtSortClientName = new DataTable();
        static public DataTable DtClient = new DataTable();
        static public DataTable DtClientBirthday = new DataTable();
        static public DataTable DtOtborMenWoman = new DataTable();
        static public DataTable DtSelectTeg = new DataTable();
        static public DataTable DtSelectGender = new DataTable();
        static public void SelectClient(int Start, int Finish)
        {
            if (Start >= 0)
            {
                MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name, client.PhotoPath FROM `client`, `gender` WHERE client.GenderCode = gender.Code ORDER BY client.ID LIMIT {Start}, {Finish}";
                DtClient.Clear();
                MyData.Fill(DtClient);
            }
        }
        static public void SelectTeg(string nomer)
        {
            MyCommand.CommandText = $"SELECT tag.ID, tag.Title, tag.Color FROM tagofclient, tag WHERE tagofclient.ClientID = '{nomer}' AND tagofclient.TagID = tag.ID";
            DtSelectTeg.Clear();
            MyData.Fill(DtSelectTeg);
        }
        static public int SelectRowsCount()
        {
            object Count = 0;
            MyCommand.CommandText = $"SELECT COUNT(ID) FROM client";
            Count = MyCommand.ExecuteScalar();
            return Convert.ToInt32(Count);
        }
        static public bool DeleteClient(string nomer)
        {
            object count;
            MyCommand.CommandText = $"SELECT COUNT(*) AS id FROM clientservice WHERE ClientID = '{nomer}'";
            count = MyCommand.ExecuteScalar();
            if (Convert.ToInt32(count) == 0)
            {
                MyCommand.CommandText = $"DELETE FROM tagofclient WHERE ClientID = '{nomer}'";
                MyCommand.ExecuteNonQuery();
                MyCommand.CommandText = $"DELETE FROM client WHERE ID = '{nomer}'";
                if (MyCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        static public void SelectBirthdayClient()
        {
            DateTime Birthday = DateTime.Now;
            MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.Birthday LIKE '%{Birthday.ToString("MM-dd")}%'";
            DtClientBirthday.Clear();
            MyData.Fill(DtClientBirthday);
        }
        static public void OtborMenWoman(string nomer)
        {
            MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND gender.Code = '{nomer}' ORDER BY client.ID";
            DtOtborMenWoman.Clear();
            MyData.Fill(DtOtborMenWoman);
        }

        static public void SortName(int start, int finish)
        {
            MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID ORDER BY client.FirstName ASC LIMIT {start}, {finish}";
            DtSortClientName.Clear();
            MyData.Fill(DtSortClientName);
        }
        static public void SortFam(int start, int finish)
        {
            MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID ORDER BY client.FirstName ASC LIMIT {start}, {finish}";
            DtSortClientName.Clear();
            MyData.Fill(DtSortClientName);
        }
        static public void SortOtch(int start, int finish)
        {
            MyCommand.CommandText = $"SELECT client.ID, client.FirstName, client.LastName, client.Patronymic, client.Birthday, client.RegistrationDate, client.Email, client.Phone, gender.Name FROM client, gender WHERE client.GenderCode = gender.Code AND client.ID ORDER BY client.FirstName ASC LIMIT {start}, {finish}";
            DtSortClientName.Clear();
            MyData.Fill(DtSortClientName);
        }
        static public void SelectGender()
        {
            MyCommand.CommandText = $"SELECT Code, Name FROM gender";
            DtSelectGender.Clear();
            MyData.Fill(DtSelectGender);
        }
    }
}
