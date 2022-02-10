using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class State
    {
        [Key]
        public long id { get; set; }

        public string name { get; set; }
        public int countryid {get;set;}
        public Country country { get; set; }
    }
}