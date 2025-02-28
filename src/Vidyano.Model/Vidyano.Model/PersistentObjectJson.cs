using Newtonsoft.Json;
using System.ComponentModel;

namespace Vidyano.Model;

public class VidyanoPersistentObjectJson
{
    [JsonRequired]
    public required VidyanoPersistentObject PersistentObject { get; set; }

    [JsonRequired]
    public required List<VidyanoQuery> Queries { get; set; }
}

public class VidyanoPersistentObject
{
    [JsonRequired]
    public required Guid Id { get; set; }

    [JsonRequired]
    public required string SchemaName { get; set; }

    [JsonRequired]
    public required string Type { get; set; }

    public string? Salt { get; set; }

    public string? Breadcrumb { get; set; }

    [JsonRequired]
    public required string ContextProperty { get; set; }

    public string? QueryContextProperty { get; set; }
    
    public string? SortOptions { get; set; }

    [JsonRequired]
    [Description("The translated text on the website")]
    public required Dictionary<string, string> Label { get; set; }

    public int? StateBehavior { get; set; }
    
    public int? QueryLayoutMode { get; set; }

    public required List<VidyanoPersistentObjectGroup> Groups { get; set; }

    public required List<VidyanoPersistentObjectTab> Tabs { get; set; }

    public required List<VidyanoPersistentObjectAttribute> Attributes { get; set; }

    public required List<Guid> Queries { get; set; }
}

public class VidyanoPersistentObjectGroup
{
    [JsonRequired]
    public required Guid Id { get; set; }

    [JsonRequired]
    public required string Name { get; set; }

    [JsonRequired]
    [Description("The translated text on the attribute group")]
    public required Dictionary<string, string> Label { get; set; }

}

public class VidyanoPersistentObjectTab
{
    [JsonRequired]
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    [Description("The translated text on the tab")]
    public required Dictionary<string, string> Label { get; set; }

    public int? ColumnCount { get; set; }
}

public class VidyanoPersistentObjectAttribute
{
    [JsonRequired]
    public required Guid Id { get; set; }

    public string? DisplayAttribute { get; set; }

    public Guid? LookupId { get; set; }

    public int? Offset { get; set; }

    public string? Rules { get; set; }

    public required string Name { get; set; }

    public bool? IsReadOnly { get; set; }

    public string? SortExpression { get; set; }

    public bool? TriggersRefresh { get; set; }
    
    public string? DataTypeHints { get; set; }

    [Description("The translated text on the tab")]
    public required Dictionary<string, string> Label { get; set; }

    public int? Visibility { get; set; }

    public int? ColumnSpan { get; set; }
    
    public string? DefaultValue { get; set; }
    
    public string? CustomDefaultValue { get; set; }

    [JsonRequired]
    public required JsonReference DataType { get; set; }

    [JsonRequired]
    public required JsonReference Group { get; set; }

    [JsonRequired]
    public required JsonReference Tab { get; set; }
}

public class VidyanoQuery
{
    [JsonRequired]
    public required Guid Id { get; set; }

    [JsonRequired]
    public required string Source { get; set; }

    public bool? AutoQuery { get; set; }

    [JsonRequired]
    public required string Name { get; set; }

    [JsonRequired]
    public required Dictionary<string, string> Label { get; set; }

    [JsonRequired]
    public required JsonReference PersistentObject { get; set; }
}

public class VidyanoQueryColumn
{
    [JsonRequired]
    public required Guid Id { get; set; }

    [JsonRequired]
    public required JsonReference Attribute { get; set; }
}