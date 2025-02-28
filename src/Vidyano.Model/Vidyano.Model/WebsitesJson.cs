using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Vidyano.Model;

public class VidyanoWebsitesJson
{
    [JsonRequired]
    [Description("List of websites")]
    public required Dictionary<string, VidyanoWebsite> Websites { get; set; }
}

public class VidyanoWebsite
{
    [JsonRequired]
    [Description("The translated text on the website")]
    public required Dictionary<string, string> Label { get; set; }

    [JsonRequired]
    [Description("Website type")]
    public required int Type { get; set; }

    [JsonRequired]
    [Description("The website's URL")]
    public required List<string> Bindings { get; set; }
}