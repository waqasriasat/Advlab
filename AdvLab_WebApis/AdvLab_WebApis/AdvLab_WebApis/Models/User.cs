using System.ComponentModel.DataAnnotations;

namespace AdvLab_WebApis.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LoginStatus { get; set; }
        public string LoginStatusIP { get; set; }
        public string LoginStatusComp { get; set; }
        public string NSend { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        [Required]
        public Nullable<int> EmpID { get; set; }
        public string UName { get; set; }
        [Required]
        public string UPassword { get; set; }
        public string ClientV { get; set; }
        public string Status { get; set; }
        public string Place { get; set; }
        public string PlaceCategory { get; set; }
        [Required]
        public string CNL { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Depart { get; set; }
        [Required]
        public string SubDepart { get; set; }
        [Required]
        public string Placement { get; set; }
        [Required]
        public string Designation { get; set; }
        public Nullable<int> UId { get; set; }
        public string Idloc { get; set; }
        public string CompMac { get; set; }
        public string PayGenerate { get; set; }
        [Required]
        public Nullable<int> RoleID { get; set; }
        public string Token { get; set; }
    }
}
