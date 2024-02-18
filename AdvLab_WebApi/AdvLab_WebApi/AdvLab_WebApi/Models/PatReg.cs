namespace AdvLab_WebApi.Models
{
    public class PatReg
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<int> MrNo { get; set; }
        public string Initial { get; set; }
        public string FirstName { get; set; }
        public string Relation { get; set; }
        public string? RelName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string AgeType { get; set; }
        public Nullable<System.DateTime> DBO { get; set; }
        public string ContNo { get; set; }
        public string? Email { get; set; }
        public Nullable<int> UId { get; set; }
        public string? Uname { get; set; }
        public string? Idloc { get; set; }
        public string? CompMac { get; set; }
    }
}
