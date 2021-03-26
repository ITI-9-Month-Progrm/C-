using BusinessLogicLayer.Entities;
using BusinessLogicLayer.EntityList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer.EntityManager
{
    public static class TitleManager
    {
        private static DBManager dBManager = new DBManager();
        public static TitleList ShowData()
        {
           
            TitleList result = new TitleList();
            try {
                return
                    (covnertDataTableToList(dBManager.executeDataTableQuiry("ShowData")));
            }
            catch
            {

            }
            return result;
        }
        public static bool DeleteTitleById(string ID)
        {
            try
            {
                Dictionary<string, Object> paramList = new Dictionary<string, object>() { ["ID"] = ID };
                if(dBManager.executeNonQuiry("DeleteTitleById", paramList) > 0) { return true; }
            }
            catch
            {

            }

            return false;
        }
        public static bool UpdateTitleById(string ID, string TITILE, string TYPE)
        {
            try
            {
                Dictionary<string, Object> paramList = new Dictionary<string, object>() { ["ID"] = ID, ["TITILE"] = TITILE, ["TYPE"] = TYPE };
                if (dBManager.executeNonQuiry("UpdateTitleById", paramList) > 0) { return true; }
            }
            catch
            {

            }

            return false;
        }
        public static bool InsertNewTitle(string ID, string TITILE, string TYPE)
        {
            try
            {
                Dictionary<string, Object> paramList = new Dictionary<string, object>() { ["ID"] = ID, ["TITILE"] = TITILE, ["TYPE"] = TYPE };
                if (dBManager.executeNonQuiry("InsertNewTitle", paramList) > 0) { return true; }
            }
            catch
            {

            }

            return false;
        }
        internal static TitleList covnertDataTableToList(DataTable dataTable)
        {
            TitleList titles = new TitleList();
            try{
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    titles.Add(covnertDataRowToTitle(dataRow));
                }
            }
            catch { }
            return titles;
        }
        internal static Title covnertDataRowToTitle(DataRow dataRow)
        {
            Title title = new Title();
            try
            {
                title.title_id = dataRow["title_id"].ToString();
                
                title.title = dataRow["title"].ToString();
                
                title.type = dataRow["type"].ToString();
                
                title.pub_id = dataRow["pub_id"]?.ToString() ?? "Not Found";
                
                title.notes = dataRow["notes"]?.ToString() ?? "Not Found";
                
                if (decimal.TryParse(dataRow["price"]?.ToString() ?? "0.0", out decimal tempPrice))
                    title.price = tempPrice;
                
                if (decimal.TryParse(dataRow["advance"]?.ToString() ?? "0.0", out decimal tempAdvance))
                    title.advance = tempAdvance;

                if (int.TryParse(dataRow["royalty"]?.ToString() ?? "0", out int tempRoyalty))
                    title.royalty = tempRoyalty;

                if (int.TryParse(dataRow["ytd_sales"]?.ToString() ?? "0", out int tempyYtdSales))
                    title.ytd_sales = tempyYtdSales;
                if (DateTime.TryParse(dataRow["pubdate"]?.ToString() ?? "00/00/0000", out DateTime dateTime))
                    title.pubdate = dateTime;
                title.State = EntityState.Unchanged;

            }
            catch { }
            return title;
        }
    }
}
