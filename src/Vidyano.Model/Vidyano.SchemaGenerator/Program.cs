using Newtonsoft.Json.Schema.Generation;
using System;
using Vidyano.Model;

var generator = new JSchemaGenerator { DefaultRequired = Newtonsoft.Json.Required.Default };

var outputDir = "output";

if (!Directory.Exists(outputDir))
    Directory.CreateDirectory(outputDir);

GenerateSchema<VidyanoCultureJson>("culture.schema.json");
GenerateSchema<VidyanoModelJson>("model.schema.json");
GenerateSchema<VidyanoPersistentObjectJson>("persistentobject.schema.json");
GenerateSchema<VidyanoProgramUnitsJson>("programUnits.schema.json");
GenerateSchema<VidyanoSecurityJson>("security.schema.json");
GenerateSchema<VidyanoWebsitesJson>("websites.schema.json");


void GenerateSchema<T>(string fileName)
{
    var schema = generator.Generate(typeof(T));
    using var fs = new System.IO.FileStream(Path.Combine(outputDir, fileName), System.IO.FileMode.Create);
    using var writer = new StreamWriter(fs);
    writer.Write(schema.ToString());
}