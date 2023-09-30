using Försök_TeaterGruppen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Försök_TeaterGruppen.Services;

public class MenuService
{
    private readonly ActerService _acterService = new ActerService();

    
    public void MainMenu()
    {
        
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Välj ett av följande alternativ (0-5): ");
            Console.WriteLine("1. Skapa en ny medlem");
            Console.WriteLine("2. Visa alla medlemmar");
            Console.WriteLine("3. Visa en specifik medlem"); 
            Console.WriteLine("4. Radera en medlem ur gruppen");
            Console.WriteLine("0. Avsluta");
            var option = Console.ReadLine();

            switch (option)
            {
                case ("1"):
                    CreateMenu();
                    break;
                case ("2"):
                    GetAllActerMembers();
                    
                    break; 
                case ("3"):
                    GetOneActerMember();
                    
                    break;
                case ("4"):
                    RemoveActerMember();
              
                    break;
                case ("0"):
                    exit = true;
                   
                    break;
                default:
                    break;

            }
           
        }
        while (exit == false); 

    }
    public void CreateMenu()
    {
        Console.Clear();
        Console.WriteLine("Skapa en ny medlem");
        Console.WriteLine("------------------");


        var actermember = new ActerMember();

        Console.Write("Ange Gruppnamn: ");
        actermember.ActerGroupName = Console.ReadLine();

        Console.Write("Förnamn: ");
        actermember.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Efternamn: ");
        actermember.LastName = Console.ReadLine()!.Trim();

        Console.Write("email: ");
        actermember.Email = Console.ReadLine()!.Trim().ToLower();



        _acterService.AddActerMemberToList(actermember);
        Console.WriteLine("En ny teatermedlem har lagts till.");
        Console.ReadKey();


    }
    public void GetAllActerMembers()
    {
        var actermembers = _acterService.GetAllActerMembers();
        foreach (var actermember in actermembers)
        {
            Console.WriteLine(actermember.FullName);
            Console.WriteLine();
                
        }
        Console.ReadKey ();
    }
    public void GetOneActerMember()
    {
        Console.Write("Ange teatermedlemmens gruppnamn, förnamn, efternamn och emailadress: ");
        var fullname = Console.ReadLine();
        var actermember = _acterService.GetOneActerMember(fullname);
        Console.WriteLine(actermember.FullName);
        Console.WriteLine();
        Console.ReadKey ();
        
    }

    public void RemoveActerMember()
    {
        Console.Write("Ange teatermedlemmens gruppnamn, förnamn, efternamn och emailadress: ");
        var fullname = Console.ReadLine();
        _acterService.RemoveActerMember(fullname);
        
        
    }

    
        
    
}
