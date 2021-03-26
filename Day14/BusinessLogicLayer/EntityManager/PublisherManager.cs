using BusinessLogicLayer.Entities;
using BusinessLogicLayer.EntityList;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.EntityManager
{
    public class PublisherManager
    {
        private static DBManager dBManager = new DBManager();
        public static PublisherList ShowPublisherData()
        {

            PublisherList result = new PublisherList();
            try
            {
                return
                    (covnertDataTableToList(dBManager.executeDataTableQuiry("ShowPublisherData")));
            }
            catch
            {

            }
            return result;
        }
     
        internal static PublisherList covnertDataTableToList(DataTable dataTable)
        {
            PublisherList publishers = new PublisherList();
            try
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    publishers.Add(covnertDataRowToPublisher(dataRow));
                }
            }
            catch { }
            return publishers;
        }
        internal static Publisher covnertDataRowToPublisher(DataRow dataRow)
        {
            Publisher publisher = new Publisher();
            try
            {
                publisher.pub_id = dataRow["pub_id"].ToString();
                publisher.pub_name = dataRow["pub_name"]?.ToString() ?? "Not Found";
                publisher.State = EntityState.Unchanged;

            }
            catch { }
            return publisher;
        }
    }
}
