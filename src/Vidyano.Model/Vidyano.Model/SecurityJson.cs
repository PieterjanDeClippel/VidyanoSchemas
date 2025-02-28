using Newtonsoft.Json;
using System.ComponentModel;

namespace Vidyano.Model;

public class VidyanoSecurityJson
{
    [JsonRequired]
    [Description("List of security groups")]
    public required Dictionary<Guid, string> Groups { get; set; }

    [JsonRequired]
    [Description("List of group comments")]
    public required Dictionary<Guid, string> GroupComments { get; set; }

    [JsonRequired]
    [Description("List of rights")]
    public required List<VidyanoRight> Rights { get; set; }
}

public class VidyanoRight
{
    [JsonRequired]
    [Description("A random unique value")]
    public required Guid Id { get; set; }

    [JsonRequired]
    [Description("Combined string containing actions/po-or-query, or a guid when it's a query")]
    public required string Resource { get; set; }

    [JsonRequired]
    [Description("The user/group id")]
    public required Guid UserId { get; set; }
}