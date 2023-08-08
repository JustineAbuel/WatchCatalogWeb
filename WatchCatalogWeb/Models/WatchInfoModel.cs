using API.Model;
using System.Data;

namespace WatchCatalogAPI.Model
{
    public class WatchInfoModel
    {
        public int ID { get; set; }
        public string ITEM_NAME { get; set; }
        public int ITEM_NUMBER { get; set; }
        public string SHORT_DESC { get; set; }
        public string FULL_DESC { get; set; }
        public double PRICE { get; set; }
        public string CALIBER { get; set; }
        public string CHRONOGRAPH { get; set; }
        public string WEIGHT { get; set; }
        public string HEIGHT { get; set; }
        public string DIAMETER { get; set; }
        public string THICKNESS { get; set; }
        public string JEWEL { get; set; }
        public string CASE_MATERIAL { get; set; }
        public string STRAP_MATERIAL { get; set; }
        public string ITEM_INSERTED { get; set; }
        public int IMAGE_ID { get; set; }
        public string IMAGE { get; set; }
        public WatchInfoModel()
        {

        }
    }
    public class WatchInfoModelList
    {
        public List<WatchInfoModel> watchInfoModels { get; set; }
        public RequestModel Request { get; set; }

    }
    public class WatchInfoModelByID
    {
        public int ID { get; set; }
        public string ITEM_NAME { get; set; }
        public int ITEM_NUMBER { get; set; }
        public string SHORT_DESC { get; set; }
        public string FULL_DESC { get; set; }
        public double PRICE { get; set; }
        public string CALIBER { get; set; }
        public string CHRONOGRAPH { get; set; }
        public string WEIGHT { get; set; }
        public string HEIGHT { get; set; }
        public string DIAMETER { get; set; }
        public string THICKNESS { get; set; }
        public string JEWEL { get; set; }
        public string CASE_MATERIAL { get; set; }
        public string STRAP_MATERIAL { get; set; }
        public string ITEM_INSERTED { get; set; }
        public int IMAGE_ID { get; set; }
        public string IMAGE { get; set; }
        public RequestModel Request { get; set; }
        public WatchInfoModelByID()
        {

        }
    }

    public class InsertWatchInfo
    {
        public string ITEM_NAME { get; set; }
        public int ITEM_NUMBER { get; set; }
        public string SHORT_DESC { get; set; }
        public string FULL_DESC { get; set; }
        public double PRICE { get; set; }
        public string CALIBER { get; set; }
        public string CHRONOGRAPH { get; set; }
        public string WEIGHT { get; set; }
        public string HEIGHT { get; set; }
        public string DIAMETER { get; set; }
        public string THICKNESS { get; set; }
        public string JEWEL { get; set; }
        public string CASE_MATERIAL { get; set; }
        public string STRAP_MATERIAL { get; set; }
        public string IMAGE { get; set; }
       
    }
}
