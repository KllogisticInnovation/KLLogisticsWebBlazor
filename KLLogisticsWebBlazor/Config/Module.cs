namespace KLLogisticsWebBlazor.Config
{
	public class Module
	{
		
	}
	public class Stringclass
	{
		public static string? SaveDatenow;
	}

	public class LoginModuleAtribut
	{
		public static string? Userid;
		public static string? Username;
		public static string? Password;
		public static string? Facility;
		public static string? BusinesUnit;
    }
	public class NavMenuAttribut
	{
		public static string BU = "";
		public static string Facility = "";
		public static string Inbound_Url = "/D_Inbound";
		public static string Storing_Url = "/D_Storing" ;
		public static string Inventory_Url = "/D_Inventory";
		public static string Outbound_Url = "/D_Outbound";
		public static string Planner_Url = "/D_Planner";
		public static string Maintenance_Url = "/D_Maintenance";
		public static string Ga_Url = "/D_Ga";                                                                                                                            
	}
	public class UrlModule
	{
		//public static string? BaseModuleUrl;
		//public static string BaseModuleUrl = "https://processing-ch-laughing-magazines.trycloudflare.com/";
		public static string BaseModuleUrl = "http://172.31.7.219:9001/";
	}
}
