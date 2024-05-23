namespace widgetmaker.Data.Models;

public class Inventory
{
	public int InventoryId { get; set; }
	public required int WidgetId { get; set; }
	public Widget Widget { get; set; }
	public required int Count { get; set; }
	public DateTimeOffset? CreatedOn { get; set; }
}


