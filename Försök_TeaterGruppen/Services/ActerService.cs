using Försök_TeaterGruppen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Försök_TeaterGruppen.Services;

public class ActerService
{
    private List<ActerMember> _actermembers = new List<ActerMember>();
    public void AddActerMemberToList(ActerMember actermember)
    {
        _actermembers.Add(actermember);
    }

    public List<ActerMember> GetAllActerMembers()
    {
        return _actermembers;
    }
    public ActerMember GetOneActerMember(string fullname)
    {
        return _actermembers.FirstOrDefault(x => x.FullName == fullname)!;
    }
    public  void RemoveActerMember(string fullname)
    {
        var actermember = GetOneActerMember(fullname);
        _actermembers.Remove(actermember);
    }

}
