using BlazorApp.Models;
using System.Text.Json;

namespace BlazorApp.Data
{
    public class PersonsDataSet
    {
        private static List<Person> data = new List<Person>();
        public List<Person> GetData() {
            if (data.Count == 0) {
                var path = @"C:\Users\Student EN\Downloads\data2024.json";
                var jsonstring = File.ReadAllText(path);
                var lst = JsonSerializer.Deserialize<List<Person>>(jsonstring);
                if(lst != null) data.AddRange(lst);
            }
            return data;
        }
    }
}
