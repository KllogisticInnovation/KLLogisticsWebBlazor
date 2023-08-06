namespace KLLogisticsWebBlazor.Models
{

    public class Aging_Loc_staged
    {
        public string tipe_order { get; set; }
        public string Total_DO { get; set; }
        public string one_Day {get;set;}
        public string two_Day { get;set;}
        public string three_Day { get; set; }

    }

    public class totalcaseid
    { 
    public string? STATUS { get; set; }
    public string? GRW { get; set; }
    public string? FLOW_THRU { get; set; }
    public string? CUSTOMER { get; set; }
    }

    public class plangrw
    {
        public string? PROSESS { get; set; }
        public string? DONE { get; set; }
        public string? TOTAL { get; set; }
        public string? ACH { get; set; }

    }
    public class planft
    {
        public string? PROSESS { get; set; }
        public string? DONE { get; set; }
        public string? TOTAL { get; set; }
        public string? ACH { get; set; }

    }
    public class plancs
    {
        public string? PROSESS { get; set; }
        public string? DONE { get; set; }
        public string? TOTAL { get; set; }
        public string? ACH { get; set; }

    }

}
