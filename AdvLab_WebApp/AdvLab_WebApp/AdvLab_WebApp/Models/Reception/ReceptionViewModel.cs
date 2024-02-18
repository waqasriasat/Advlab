namespace AdvLab_WebApp.Models.Reception
{
    public class ReceptionViewModel
    {
        public PatReg PatRegModel { get; set; }
        public DescCashier DescCashierModel { get; set; }
        public DescLab DescLabModel { get; set; }
        public IEnumerable<DescLab> DescLabModelItem { get; set; }
    }
}
