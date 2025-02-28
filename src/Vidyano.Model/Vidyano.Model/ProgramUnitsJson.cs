using Newtonsoft.Json;
using System.ComponentModel;

namespace Vidyano.Model;

public class VidyanoProgramUnitsJson
{
    [JsonRequired]
    [Description("List of program units shown in the sidebar of the application")]
    public required List<VidyanoProgramUnit> ProgramUnits { get; set; }
}

public class VidyanoProgramUnit
{

    [JsonRequired]
    [Description("A name for the program unit")]
    public required string Name { get; set; }

    [Description("The position of the program unit")]
    public int Offset { get; set; }

    [JsonRequired]
    [Description("The translated text on the program unit")]
    public required Dictionary<string, string> Title { get; set; }

    [JsonRequired]
    [Description("Allows you to group items")]
    public required List<VidyanoProgramUnitGroup> Groups { get; set; }

    [JsonRequired]
    [Description("List of program unit items")]
    public required List<VidyanoProgramUnitItem> Items { get; set; }

    [Description("Automatically open the first item in the group")]
    public bool OpenFirst { get; set; }
}

public class VidyanoProgramUnitGroup
{
    [JsonRequired]
    public required Guid Id { get; set; }

    [JsonRequired]
    [Description("The translated text on the group")]
    public required Dictionary<string, string> Title { get; set; }
}

public class VidyanoProgramUnitItem
{
    [JsonRequired]
    [Description("The translated text on the item")]
    public required Dictionary<string, string> Title { get; set; }

    [JsonRequired]
    [Description("a name for the item")]
    public required string Name { get; set; }

    [Description("The position of the item")]
    public int? Offset { get; set; }

    [Description("Whether or not this is a horizontal separator")]
    public bool IsSeparator { get; set; }

    [Description("What query (list) to show in the right-hand pane")]
    public required JsonReference Query { get; set; }

    [Description("What persistent-object to show in the right-hand pane")]
    public required JsonReference PersistentObject { get; set; }

    [Description("The group this item belongs to")]
    public required JsonReference Group { get; set; }
}

public class JsonReference
{
    [JsonRequired, JsonProperty("$ref")]
    public required string Ref { get; set; }
}