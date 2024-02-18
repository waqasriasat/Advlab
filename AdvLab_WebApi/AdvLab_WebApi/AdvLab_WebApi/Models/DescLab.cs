namespace AdvLab_WebApi.Models
{
    public class DescLab
    {
        public int ID { get; set; }
        public string CpName { get; set; }
        public string BarcodeNo { get; set; }
        public Nullable<int> InvNo { get; set; }
        public Nullable<int> MRNO { get; set; }
        public Nullable<int> LabNo { get; set; }
        public string CpNo { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<int> DescID { get; set; }
        public string TestCode { get; set; }
        public string DescName { get; set; }
        public string ReportHeading { get; set; }
        public string Gname { get; set; }
        public Nullable<System.DateTime> RepDate { get; set; }
        public Nullable<int> Charges { get; set; }
        public string Category { get; set; }
        public string DStatus { get; set; }
        public Nullable<System.DateTime> StatusDate { get; set; }
        public string Placement { get; set; }
        public string Depart { get; set; }
        public string? SubDepart { get; set; }
        public string? Section { get; set; }
        public string CNL { get; set; }
        public Nullable<int> UId { get; set; }
        public string Uname { get; set; }
        public string Idloc { get; set; }
    }
}
