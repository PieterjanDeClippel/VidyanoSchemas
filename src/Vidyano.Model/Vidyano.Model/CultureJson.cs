using Newtonsoft.Json;
using System.ComponentModel;

namespace Vidyano.Model;

public class VidyanoCultureJson
{
    [JsonRequired]
    [Description("List of available languages")]
    public required Dictionary<string, VidyanoLanguage> Languages { get; set; }

    [JsonRequired]
    [Description("List of messages")]
    public required Dictionary<string, VidyanoMessage> Messages { get; set; }
}

public class VidyanoLanguage
{
    [JsonRequired]
    [Description("Translations for this language")]
    public required Dictionary<string, string> Name { get; set; }
}

public class VidyanoMessage
{
    [JsonRequired]
    [Description("The message")]
    public required Dictionary<string, string> Value { get; set; }

    [Description("Whether this message should be available on the client-side too")]
    public bool IsClient { get; set; }

    [Description("Whether or not this is a built-in message")]
    public bool IsSystem { get; set; }
}