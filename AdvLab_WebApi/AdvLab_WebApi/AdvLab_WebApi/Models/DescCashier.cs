namespace AdvLab_WebApi.Models
{
    public class DescCashier
    {
        public int ID { get; set; }
        public string CpName { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        public Nullable<int> InvNo { get; set; }
        public Nullable<int> MRNO { get; set; }
        public Nullable<int> LabNo { get; set; }
        public string CpNo { get; set; }
        public Nullable<int> ClientID { get; set; }
        public string ClientName { get; set; }
        public string ConsName { get; set; }
        public string ClientNo { get; set; }
        public string Comments { get; set; }
        public Nullable<double> GrossA { get; set; }
        public Nullable<double> DiscPer { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> TotalA { get; set; }
        public Nullable<double> PaidA { get; set; }
        public Nullable<double> BlanceA { get; set; }
        public string PaymentMode { get; set; }
        public string? CreditCardNo { get; set; }
        public Nullable<double> TaxN { get; set; }
        public string TestCode { get; set; }
        public Nullable<int> UId { get; set; }
        public string Uname { get; set; }
        public string Idloc { get; set; }
        public Nullable<System.DateTime> RbalanceDate { get; set; }
        public Nullable<double> RbalanceA { get; set; }
        public Nullable<int> RUId1 { get; set; }
        public string? RUname { get; set; }
        public string? RIdloc1 { get; set; }
        public Nullable<double> CurrentB { get; set; }
        public Nullable<int> BillNo { get; set; }
        public string? F_VNo { get; set; }
        public string? CStatus { get; set; }
        public string? RV { get; set; }
        public string? SV { get; set; }
        public string? RV1 { get; set; }
        public string Pwd { get; set; }
        public string InvoiceSMS { get; set; }
        public string DortocSMS { get; set; }

    }
}
