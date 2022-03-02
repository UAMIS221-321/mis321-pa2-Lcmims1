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
                break;
            default:
                Console.WriteLine("\nYou entered: " + (p1choice) + "\nSorry that's an invaild selection.");
                break; 
        }
        }
       
        Character player2 = new Character();
        int p2choice = 0;
        // bool shouldExit = false;
        while(!shouldExit){
            
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
                break;
                default:
                    Console.WriteLine("\nYou entered: " + (p2choice) + "\nSorry that's an invaild selection.");
                    break;
            }

        }   

        
        player2.PrintStats( player2, damageDealt);

        return 0;
    }
    static Character JS(){
        Character js = new Character();
        js.Name = "Jack Sparrow";
        js.characterbehavior =new JackSparrow(); 
        Console.WriteLine("Great Choice! Your attack will be distracting your opponent\n\n");
        return js;
    }
    static Character DJ(){
        Character dj = new Character();
        dj.Name = "Davy Jones";
        dj.characterbehavior = new DavyJones();
        Console.WriteLine("Great Choice! Your attack will be cannon fire\n\n");
        return dj;
    }
    static Character WT(){
        Character wt = new Character();
        wt.Name = "Will Turner";
        wt.characterbehavior = new WillTurner();
        Console.WriteLine("Great Choice! Your attack will be using your sword\n\n");
        return wt;
    }
    
    static void PlayGame(){
        Random pickPlayer = new Random();
        //Who goes first 
        int whoGoesFirst = pickPlayer.Next(1,2);
        if(whoGoesFirst != 0){
            if(whoGoesFirst == 2){
                Player2Turn();
            }
            whoGoesFirst = 0;
        }
        // PrintStats(Character player2, double damageDealt);
    }
    static void Player2Turn(){

    }

    static void GamePlayplayer(Character player1, Character player2, double damageDealt){
        while(player1.health > 0 && player2.health > 0){
        player1.Attack();
        PrintStats(player2, damageDealt);
        player2.Attack();
        PrintStats(player2,damageDealt);
        }

        if(player2.health = 0){
            System.Console.WriteLine(Player1 + "has won!");
        }

        if(player1.health = 0){
            System.Console.WriteLine(Player2 + "has won!");
        }
       
    }
    p1choic attack
    printstats
    static void EndGame(){
        Console.WriteLine("Thank you for playing.");
    }
    }
}
