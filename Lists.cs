using System.Collections;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace Studieplatform;

public class Lists
{
    public static string savedJson { get; set; } = "";

 public List<Kurs> _CourseList{ get; private set; } = new List<Kurs>();

      public void AddCourse(Kurs course)
    {
        _CourseList.Add(course);
    }

    public override string ToString()
    {
        return $"{savedJson}";
    }

    public static string ConvertJson(object list)
    {
       var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
             WriteIndented = true,
             Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        var path = string.Concat(Environment.CurrentDirectory,"/Data/data.json");
        var json = JsonSerializer.Serialize(list, options);

        File.WriteAllText(path,json);
        savedJson = File.ReadAllText(path);
        
        return savedJson; 
    }

}
