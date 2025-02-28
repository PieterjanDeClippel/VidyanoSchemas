using Newtonsoft.Json;
using System.ComponentModel;

namespace Vidyano.Model;

public class VidyanoModelJson
{
    [JsonRequired]
    [Description("List of custom actions")]
    public required Dictionary<string, VidyanoAction> Actions { get; set; }

    [JsonRequired]
    [Description("List of data types")]
    public required Dictionary<string, VidyanoDataType> DataTypes { get; set; }
    public bool Verbose { get; set; }
    public string? ServiceVersion { get; set; }

    [JsonRequired]
    [Description("The model hash")]
    public required string ModelHash { get; set; }

    [JsonRequired]
    [Description("The seeder hash")]
    public required string SeederHash { get; set; }
}

public class VidyanoAction
{
    [Description("A message to show before the action is executed")]
    public string? ConfirmationMessageKey { get; set; }

    [Description("A description of the action")]
    public string? Description { get; set; }

    [JsonRequired]
    [Description("Text on the action's button")]
    public required Dictionary<string, string> DisplayName { get; set; }

    [Description("The group name of the action")]
    public string? GroupActionName { get; set; }

    [Description("The icon of the action")]
    public string? Icon { get; set; }

    [Description("A custom icon for the action")]
    public string? IconName { get; set; }

    public int? Intent { get; set; }

    public bool? IsSystem { get; set; }

    [Description("Preserve selection when reloading the query")]
    public bool? KeepSelectionOnRefresh { get; set; }

    [Description("The position of the action")]
    public int? Offset { get; set; }

    [Description("Provides a dropdown from which the user can choose an option")]
    public Dictionary<string, string>? Options { get; set; }

    [Description("When this action is applied to a query, determines if the query should automatically reload when the Execute method has finished")]
    public bool? RefreshQueryOnCompleted { get; set; }

    [Description("The rule to determine if the action is available")]
    public string? SelectionRule { get; set; }

    [Description("Whether to show this action on a Query, PersistentObject, Dialog, ...")]
    public int? ShowedOn { get; set; }
}

public class VidyanoDataType
{
    [JsonRequired]
    public required Guid Id { get; set; }

    [JsonRequired]
    [Description("Is this a default data type")]
    public required bool IsSystem { get; set; }
    
    [JsonRequired]
    [Description("Whether or not the data type can be sorted on")]
    public required bool CanSort { get; set; }

    [JsonRequired]
    [Description("Whether or not the data type can be filtered on")]
    public required bool CanFilter { get; set; }

    [JsonRequired]
    [Description("Whether or not the data type can be distincted on")]
    public required bool CanListDistincts { get; set; }
}