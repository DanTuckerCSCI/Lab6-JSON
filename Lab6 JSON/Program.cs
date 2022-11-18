using Lab6_JSON.Models;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
// points to data 
var filePath= root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Guns and Control.json";
var dataPath= root + $"{Path.DirectorySeparatorChar}Data";

var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

foreach (string filename in Directory.GetFiles(dataPath))
{
    string jsonString = string.Empty;
    using (StreamReader sr = new StreamReader(filename))
    {
        jsonString = sr.ReadToEnd();
    }

    Console.WriteLine(jsonString);

    var books = JsonSerializer.Deserialize<Book>(jsonString, options);

    Console.WriteLine(books);
}
