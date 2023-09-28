using Försök_TeaterGruppen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Försök_TeaterGruppen.Services;

public class MenuService
{
    private readonly ActerMember acterMember = new ActerMember();

    
    public void MainMenu()
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Välj ett av följande alternativ (0-4): ");
            Console.WriteLine("1. Skapa en ny användare");
            Console.WriteLine("3. Visa alla användare");
            Console.WriteLine("2. Visa en specifik användare");           
            Console.WriteLine("0. Avsluta");
            var option = Console.ReadLine();

            switch (option)
            {
                case ("1"):
                    CreateMenu();
                    break;
                case ("2"):
                    break; 
                case ("3"):
                    break;
                case ("0"):
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
        Console.WriteLine("Skapa en ny användare");
        Console.WriteLine("---------------------");

        var actermember = new ActerMember();
        Console.Write("Skapa en ny användare");
        actermember.Create(actermember);

        Console.Write("Förnamn: ");
        actermember.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Efternamn: ");
        actermember.LastName = Console.ReadLine()!.Trim();

        Console.Write("email: ");
        actermember.Email = Console.ReadLine()!.Trim().ToLower();


        Console.WriteLine("En ny teatermedlem har lagts till.");
        Console.ReadKey();
    }

    public void AddActerMemberMenu()
    {
        var actermember = new ActerMember();
        Console.WriteLine("Ange Gruppnamn: ");
        _actermembers.Add(actermember);

        Console.Write("");
        Console.Write("Ange gruppnamn: ");
        actermember.ActerGroupName = Console.ReadLine()!.Trim();
        Console.Write("Ange Förnamn: ");
        actermember.FirstName = Console.ReadLine()!.Trim();
        Console.Write("Ange Efternamn: ");
        actermember.LastName = Console.ReadLine()!.Trim();
        Console.Write("Ange emailadress: ");
        actermember.Email = Console.ReadLine()!.Trim().ToLower();
        Console.Write("");

        _actermembers.Create(actermember);

        Console.ReadKey();
    

    }

}
