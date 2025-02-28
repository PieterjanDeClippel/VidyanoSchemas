﻿using Newtonsoft.Json;

namespace Vidyano.Model;

public class VidyanoModelJson
{
    [JsonRequired] public required Dictionary<string, VidyanoAction> Actions { get; set; }
    [JsonRequired] public required Dictionary<string, VidyanoDataType> DataTypes { get; set; }
    public bool Verbose { get; set; }
    public string ServiceVersion { get; set; }
    [JsonRequired] public required string ModelHash { get; set; }
    [JsonRequired] public required string SeederHash { get; set; }
}

public class VidyanoAction
{
    public string? ConfirmationMessageKey { get; set; }
    public string? Description { get; set; }
    [JsonRequired] public required Dictionary<string, string> DisplayName { get; set; }
    public string? GroupActionName { get; set; }
    public string? Icon { get; set; }
    public string? IconName { get; set; }
    public int? Intent { get; set; }
    public bool? IsSystem { get; set; }
    public bool? KeepSelectionOnRefresh { get; set; }
    public int? Offset { get; set; }
    public Dictionary<string, string>? Options { get; set; }
    public bool? RefreshQueryOnCompleted { get; set; }
    public string? SelectionRule { get; set; }
    public int? ShowedOn { get; set; }
}

public class VidyanoDataType
{
    [JsonProperty("$id"), JsonRequired]
    public required string Id { get; set; }

    [JsonRequired] public required bool IsSystem { get; set; }
    [JsonRequired] public required bool CanSort { get; set; }
    [JsonRequired] public required bool CanFilter { get; set; }
    [JsonRequired] public required bool CanListDistincts { get; set; }
}