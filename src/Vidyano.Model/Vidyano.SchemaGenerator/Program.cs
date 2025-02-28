using Newtonsoft.Json.Schema.Generation;
using System;
using Vidyano.Model;

var generator = new JSchemaGenerator();
var schema = generator.Generate(typeof(VidyanoModelJson));

var outputDir = "output";

if (!Directory.Exists(outputDir))
    Directory.CreateDirectory(outputDir);

using var fs = new System.IO.FileStream(Path.Combine(outputDir, "model.schema.json"), System.IO.FileMode.Create);
using var writer = new StreamWriter(fs);
await writer.WriteAsync(schema.ToString());
