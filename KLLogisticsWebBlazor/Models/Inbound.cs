namespace KLLogisticsWebBlazor.Models
{
    public class Inbound
    {
        public  string? labels { get; set; }
        public  string? data { get; set; }
    }
    public class Inbound_Convert
    {
        public string? Status { get; set; }
        public double? Total { get; set; }
    }

    public class Inbound_Import
    {
        public string? WT_SCHEDULE { get; set; }
        public int VALUE { get; set; }
    }         
    public class Inbound_Import_List
    {
        public string? WT1 { get; set; }
        public string? WT2 { get; set; }
        public string? WT3 { get; set; }
        public string? WT4 { get; set; }
    }    
    
    public class Inbound_Local
    {
        public string? WT_SCHEDULE { get; set; }
        public int VALUE { get; set; }
    }

    public class Inbound_Local_List
    {
        public int WT1 { get; set; }
        public int WT2 { get; set; }
        public int WT3 { get; set; }
        public int WT4 { get; set; }
    }

    public class Inbound_Working_Process_Import
    {
        public string? LIST_PROCESS { get; set; }
        public float? VALUE { get; set; }
        public string? FILL { get; set; }
    }
    public class Inbound_Working_Process_Local
    {
        public string? LIST_PROCESS { get; set; }
        public float? VALUE { get; set; }
        public string? FILL { get; set; }

    }
    public class Inbound_Working_Process_All
    {
        public string? LIST_PROCESS { get; set; }
        public float? VALUE { get; set; }
        public string? Fill { get; set; }
    }
    public class Inbound_Productivity_Unloading
    {
        public string? SHIFT { get; set; }
        public string? TEAM { get; set; }
        public string? NIK_TEAM_LEADER { get; set; }
        public string? NAMA_TEAM_LEADER { get; set; }
        public int? TARGET_TEAM { get; set; }
        public int? ACTUAL_TEAM { get; set; }
        public int? LPN { get; set; }
        public float? PROGRES { get; set; }
    }
    public class Inbound_Productivity_Unloading_All
    {
        public string? SHIFT { get; set; }
        public int? TARGET_SHIFT { get; set; }
        public int? PROCESS { get; set; }
        public int? RESULTS { get; set; }

    }
    public class PlanningInbound
    {
        public string? IMPORT { get; set; }
        public string? LOCAL { get; set; }

    }

    public class WorkloadWt_Import
    {
        public string? WT { get; set; }
        public string? PLAN { get; set; }
        public string? ACTUAL { get; set; }
        public string? PROCESS { get; set; }
    }
    public class GetworkingDetail_Inbound
    {
        public string? WHSEID { get; set; }
        public string? TYPE { get; set; }
        public string? PIB { get; set; }
        public string? CONTAINER { get; set; }
        public string? STATUS { get; set; }
    }

}
