using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolomkaProgrammVersion2
{
    class ClassClientAddRed : ClassConnect
    {
        static public object Nomer;
        static public object ColTeg;
        static public DataTable DtTeg = new DataTable();
        static public DataTable DtTegAll = new DataTable();
        static public bool AddClient (params string[] parametri)
        {
            MyCommand.CommandText = $"INSERT INTO `client` VALUES (null, '{parametri[0]}','{parametri[1]}','{parametri[2]}','{parametri[3]}','{parametri[4]}','{parametri[5]}','{parametri[6]}','{parametri[7]}','{parametri[8]}')";
            if (MyCommand.ExecuteNonQuery() != 0)
                return true;
            else
                return false;
        }
        static public void SelectEndClient()
        {
            MyCommand.CommandText = $"SELECT ID FROM client ORDER BY ID DESC LIMIT 1";
            Nomer = MyCommand.ExecuteScalar();
        }
        static public bool RedClient(params string[] patametri)
        {
            DateTime dt = Convert.ToDateTime(patametri[4]);
            MyCommand.CommandText = $@"UPDATE client SET
                                    FirstName = '{patametri[1]}', LastName = '{patametri[2]}', Patronymic = '{patametri[3]}', 
                                    Birthday = '{dt.ToString("yyyy.MM.dd")}', RegistrationDate = '{patametri[5]}', Email = '{patametri[6]}', Phone = '{patametri[7]}', 
                                    GenderCode = '{patametri[8]}', PhotoPath = '{patametri[9]}' WHERE ID = '{patametri[0]}'";
            if (MyCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        static public void SelectTeg(string Nomer)
        {
            MyCommand.CommandText = $"SELECT ClientID, ID, Title, Color FROM tag, tagofclient WHERE tagofclient.TagID = tag.ID AND tagofclient.ClientID = '{Nomer}'";
            DtTeg.Clear();
            MyData.Fill(DtTeg);
        }
        static public void SelectTegAll()
        {
            MyCommand.CommandText = $"SELECT ID, Title, Color FROM tag";
            DtTegAll.Clear();
            MyData.Fill(DtTegAll);
        }
        static public bool InsertTeg(params string [] par)
        {
            MyCommand.CommandText = $"SELECT COUNT(*) AS ID FROM tagofclient, tag WHERE tagofclient.TagID = '{par[1]}' AND ClientID = '{par[0]}'";
            ColTeg = MyCommand.ExecuteScalar();
            if (Convert.ToInt32(ColTeg) == 0)
            {
                MyCommand.CommandText = $"INSERT INTO `tagofclient` VALUES ('{par[0]}','{par[1]}')";
                if (MyCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        static public bool DeleteTag(string Nomer,string NomerClient)
        {
            MyCommand.CommandText = $"DELETE FROM `tagofclient` WHERE TagID = '{Nomer}' AND ClientID = '{NomerClient}'";
            if (MyCommand.ExecuteNonQuery() != 0)
                return true;
            else
                return false;
        }
        //static public bool UpdateTag(string NomerClienta,string Nomer)
        //{
        //    MyCommand.CommandText = $"SELECT COUNT(*) AS ID FROM tagofclient, tag WHERE tagofclient.TagID = '{Nomer}' AND ClientID = '{NomerClienta}'";
        //    ColTeg = MyCommand.ExecuteScalar();
        //    if (Convert.ToInt32(ColTeg) == 0)
        //    {
        //        MyCommand.CommandText = $"UPDATE `tagofclient` SET TagID = '{Nomer}' WHERE ClientID = '{NomerClienta}'";
        //        if (MyCommand.ExecuteNonQuery() != 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
