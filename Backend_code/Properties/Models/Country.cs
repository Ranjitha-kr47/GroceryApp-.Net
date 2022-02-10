using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class Country
    {
        [Key]
    public int id {get;set;}
    public string code {get;set;}
    public string name {get;set;}
    public List<State> states {get;set;}

    }
}