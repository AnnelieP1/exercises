using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Försök_TeaterGruppen.Models;

public class ActerMember
{
    public string? ActerGroupName { get; set; } 
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public string? Email { get; set; } 

    public string? FullName => $"{ActerGroupName} {FirstName} {LastName} <{Email}>";

}
