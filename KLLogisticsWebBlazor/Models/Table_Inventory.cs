namespace KLLogisticsWebBlazor.Models
{
    public class Table_Inventory
    {

    }

    public class ChartData
    {
        public string Country { get; set; }
        public double Gold { get; set; }
       
        public string Warna { get; set; }
        public string Country1 { get; set; }

    }



    public class Statistics
    {
        public string Browser { get; set; }
        public double Users { get; set; }
        public string Fill { get; set; }
        public string Text { get; set; }

    }

    public class Table_WTW
    { 
      public string? Area { get; set; }
        public int? Location { get; set; }
        public int? Not_Counted{ get; set; }
        public int? Counted { get; set; }
        public decimal? Not_Counted_Percent { get; set; }
        public decimal? Counted_Percent { get; set; }
    }

    public class Table_Daily
    {
        public int? UserId { get; set; }
        public string? Employee_Name { get; set; }
        public int? Target { get; set; }
        public int? Total { get; set; }
        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }

        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }

    }

    public class Table_Daily_Detail
    {
        public string? LOC { get; set; }
        public string? SKU { get; set; }
        public int? QTY_Fisik { get; set; }
        public int? QTY_Sistem { get; set; }
        public int? ADJQTY { get; set; }
        public string? KETERANGAN { get; set; }


    }


    public class Table_Accuracy_SKU
    {
    
        public string? Area { get; set; }
     
        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }

        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }
        public string Date { get; set; } 


    }

    public class Table_Accuracy_SKU_Detail
    {

        public string? STORERKEY { get; set; }

        public string? AREAKEY { get; set; }
        public string? SKU { get; set; }

        public string? LOC { get; set; }
        public int? QTY { get; set; }
        public int? SYSQTY { get; set; }
        public int? ADJQTY { get; set; }

        public string? ADDDATE { get; set; }



    }


    public class Table_StatusADF
    {

        public string? Status { get; set; }

        public decimal? HD { get; set; }

        public decimal? PR { get; set; }
        public decimal? RC { get; set; }
        public decimal? TG { get; set; }
        public decimal? Total_ADF { get; set; }


    }

    public class Table_GroupADF
    {
        public string? Site { get; set; }

        public decimal? SKUGROUP { get; set; }
        public decimal? DESCR { get; set; }

        public decimal? Total_SKUGroup { get; set; }
        public decimal? SKU { get; set; }
        public decimal? Total_QTY { get; set; }


    }






    //Di Bawah Ini Untuk Industrial//

    public class Table_WTW_KLS
    {
        public string? Area { get; set; }
        public int? Location { get; set; }
        public int? Not_Counted { get; set; }
        public int? Counted { get; set; }
        public decimal? Not_Counted_Percent { get; set; }
        public decimal? Counted_Percent { get; set; }
    }

    public class Table_Daily_KLS
    {
        public int? UserId { get; set; }
        public string? Employee_Name { get; set; }
        public int? Target { get; set; }
        public int? Total { get; set; }

        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }

        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }


    }

    public class Table_Accuracy_SKU_KLS
    {
        //public int? Hit { get; set; }
        public string? Area { get; set; }
        //public int? Miss { get; set; }
        //public int? Total { get; set; }
        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }

        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }
        public DateTime Date { get; set; }


    }

    //Di Bawah Ini Untuk AHI//

    public class Table_WTW_AHI
    {
        public string? Area { get; set; }
        public int? Location { get; set; }
        public int? Not_Counted { get; set; }
        public int? Counted { get; set; }
        public decimal? Not_Counted_Percent { get; set; }
        public decimal? Counted_Percent { get; set; }
    }

    public class Table_Daily_AHI
    {
        public int? UserId { get; set; }
        public string? Employee_Name { get; set; }
        public int? Target { get; set; }
        public int? Total { get; set; }
        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }
        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }

    }

    public class Table_Accuracy_SKU_AHI
    {
        //public int? Hit { get; set; }
        public string? Area { get; set; }
        //public int? Miss { get; set; }
        //public int? Total { get; set; }
        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }

        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }
        public DateTime Date { get; set; }


    }


    public class Table_WTW_Cikupa
    {
        public string? Area { get; set; }
        public int? Location { get; set; }
        public int? Not_Counted { get; set; }
        public int? Counted { get; set; }
        public decimal? Not_Counted_Percent { get; set; }
        public decimal? Counted_Percent { get; set; }
    }

    public class Table_Daily_Cikupa
    {
        public int? UserId { get; set; }
        public string? Employee_Name { get; set; }
        public int? Target { get; set; }
        public int? Total { get; set; }
        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }

        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }

    }

    public class Table_Accuracy_SKU_Cikupa
    {

        public string? Area { get; set; }

        public decimal? Accuracy { get; set; }
        public decimal? Accuracy2 { get; set; }

        public decimal? HIT { get; set; }
        public decimal? MISS { get; set; }
        public DateTime Date { get; set; }


    }







}
