namespace API.Model
{
    public enum Status
    {
        Ok,

        Failed,

        Error
    }
    public enum Result
    {
        Default,
        DataTable,
        DataSet,
        Modified
    }
    public class RequestModel
    {
        public Status Status { get; set; }
        public string Description { get; set; }
    }
}
