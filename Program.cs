using System;
using System.IO;
using mis321_pa2_Lcmims1.Interfaces;

namespace mis321_pa2_Lcmims1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMenu();

            // Character myCharacter = new Character();

            // DavyJones davyJones = new DavyJones();
            // myCharacter.characterbehavior.Attack();
            // davyJones.characterbehavior.Attack();

            // JackSparrow jackSparrow = new JackSparrow();
            // jackSparrow.characterbehavior.Attack();
            // //jackSparrow.characterbehavior.Defend();

            // WillTurner willTurner = new WillTurner();
            // willTurner.characterbehavior.Attack();
        }
        static void GameMenu(){
            int userInput = 0;
            while (userInput != 4){
            Console.WriteLine("The Pirates of the Caribbean At World's End\nPlease press any key to begin the game.");
            Console.ReadKey();
            Console.WriteLine();
            userInput = MultiPlayerMode();
            }
           
        }
       
        
    static int MultiPlayerMode(){
        Character player1 = new Character();
        int p1choice = 0;
        bool shouldExit = false;
        while (!shouldExit){
        
        // Console.WriteLine("What is your name?");
        // player1.Username = Console.ReadLine();
        Console.WriteLine("Please enter the number of the player you would like to fight with:\n1)Jack Sparrow\n2)Will Turner\n3)Davy Jones\n4)Exit Game");
        p1choice = int.Parse(Console.ReadLine());
        switch(p1choice){
           case 1: 
                player1 = JS();
                break;
            case 2:
                player1 = WT();
                break;
            case 3:
                player1 = DJ();
                break;
            case 4:
                EndGame();
                shouldExit = true;
                return p1choice;
            default:
                Console.WriteLine("\nYou entered: " + (p1choice) + "\nSorry that's an invaild selection.");
                break; 
        }
        //}
       
        Character player2 = new Character();
        int p2choice = 0;
        // bool shouldExit = false;
        //while(!shouldExit){
            // Console.WriteLine("What is your name?");
            // player2.Username = Console.ReadLine();
            Console.WriteLine("Please enter the number of the player you would like to fight with:\n1)Jack Sparrow\n2)Will Turner\n3)Davy Jones\n4)Exit Game");
            p2choice = int.Parse(Console.ReadLine());
            switch(p2choice){
            case 1: 
                player2 = JS();
                break;
            case 2:
                player2 = WT();
                break;
            case 3:
                player2 = DJ();
                break;
            case 4:
                EndGame();
                shouldExit = true;
                return p2choice;
                default:
                    Console.WriteLine("\nYou entered: " + (p2choice) + "\nSorry that's an invaild selection.");
                    break;
            }
            System.Console.WriteLine("......................");
            GamePlay(player1, player2);

        }   

      
        return 0;
    }
    static Character JS(){
        Character js = new Character();
        Console.WriteLine("What is your name?");
        js.Username = Console.ReadLine();
        js.Name = "Jack Sparrow";
        js.characterbehavior =new JackSparrow(); 
        Console.WriteLine("Great Choice! Your attack will be distracting your opponent\n\n");
        return js;
    }
    static Character DJ(){
        Character dj = new Character();
        Console.WriteLine("What is your name?");
        dj.Username = Console.ReadLine();
        dj.Name = "Davy Jones";
        dj.characterbehavior = new DavyJones();
        Console.WriteLine("Great Choice! Your attack will be cannon fire\n\n");
        return dj;
    }
    static Character WT(){
        Character wt = new Character();
        Console.WriteLine("What is your name?");
        wt.Username = Console.ReadLine();
        wt.Name = "Will Turner";
        wt.characterbehavior = new WillTurner();
        Console.WriteLine("Great Choice! Your attack will be using your sword\n\n");
        return wt;
    }
    

    
    static void GamePlay(Character player1, Character player2){
       
        if(player2.AttackStrength < player1.AttackStrength){
           player2.characterbehavior.Attack(player1, player2);
            //player1.PrintStats(player2,damageDealt); 
        }
        while(player1.Health > 0 && player2.Health > 0){
        player1.characterbehavior.Attack(player2, player1);
        if(player2.Health <= 0){
        // player2.characterbehavior.Attack(player1, player2);
        break;
        }
        player2.characterbehavior.Attack(player2, player1);
        }

        if(player2.Health <= 0){
            System.Console.WriteLine(player1.Username + " has won!");
        }

        if(player1.Health <= 0){
            System.Console.WriteLine(player2.Username + " has won!");
        }
       
    }
    static void EndGame(){
        Console.WriteLine("Thank you for playing.");
    }
    }
}
