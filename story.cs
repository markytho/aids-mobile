using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome To Our Story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.Write( "Type YES or NO:   ");
      string noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
 if (noiseChoice == "YES")
  {
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
  } else if (noiseChoice == "NO")
  {
      Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
      return;
  } else 
  {
      Console.WriteLine("YO THIS SHIT IS HELLA JANK YOU HAVE TO TYPE LITERALY ONLY YES OR NO, NO SPACES");
      noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
      if (noiseChoice == "YES")
      {
       Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.You walk towards it. Do you open it or knock?");
       } else if (noiseChoice == "NO")
       {
      Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
      return;
       } else
       {
         
      Console.WriteLine("YO SERIOUSLY FUCKER MESS IT UP AGAIN AND ITS GAYME OBER. TYPE LITERALY ONLY YES OR NO, NO SPACES");
      noiseChoice = Console.ReadLine();
      noiseChoice = noiseChoice.ToUpper();
      if (noiseChoice == "YES")
      {
       Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.You walk towards it. Do you open it or knock?");
       } else if (noiseChoice == "NO")
       {
      Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
      return;
       } else
       {
         Console.WriteLine("PLAY STUPID GAMES WIN STUPID PRIZES FUCKER. \n G A M E  O V E R");
         return;
       }
     }
  }


    Console.Write("Type OPEN or KNOCK:   ");
    string doorChoice = Console.ReadLine();
    doorChoice = doorChoice.ToUpper();

    if (doorChoice == "KNOCK")
    {
      Console.WriteLine("A voice behind the door speaks. It says," + " Answer this riddle: " + "\n" + "Poor people have it. Rich people need it. If you eat it you die. What is it?");
      Console.Write("Type your answer: ");
      string riddleAnswer = Console.ReadLine();
      riddleAnswer = riddleAnswer.ToUpper();
      if (riddleAnswer == "NOTHING")
      {
          Console.WriteLine("The door opens and NOTHING is there. \nYou turn off the light and run back to your room and lock the door. \nTHE END. >:^)");
          return;
      } else
      {
          Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
          return;
      }
    } else if (doorChoice == "OPEN")
    {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
        switch (keyChoice) {
          
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. Strange... \nTHE END. >:^)");
              return;
            

            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. \nTHE END. (lel)");
              return;
            

            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. >womp womp< \nTHE END.");
              return;
            
            default:
               Console.WriteLine("We're NOT playing this game. Make a proper selection or you're done");

                Console.WriteLine("The door is locked! See if one of your three keys will open it. \nLet's see if we can't get it right this time.");
               Console.Write("Enter a number (1-3): ");
                keyChoice = Console.ReadLine();
        switch (keyChoice) {
          
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. Strange... \nTHE END. >:^)");
              return;
            

            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. \nTHE END. (lel)");
              return;
            

            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. >womp womp< \nTHE END.");
              return;
            

            default:
                  Console.WriteLine("alright stupid just lose then lulz");
                  return;
           }
        }
    } else
    {
      Console.WriteLine("ALRIGHT FUCKHEAD LETS TRY THIS AGAIN. Type OPEN or KNOCK (literally just one of those two words its really that simple):  ");
    doorChoice = Console.ReadLine();
    doorChoice = doorChoice.ToUpper();

    if (doorChoice == "KNOCK")
    {
        Console.WriteLine("A voice behind the door speaks. It says," + " Answer this riddle: " + "\n" + "Poor people have it. Rich people need it. If you eat it you die. What is it?");
        Console.Write("Type your answer: ");
      string riddleAnswer = Console.ReadLine();
      riddleAnswer = riddleAnswer.ToUpper();
      if (riddleAnswer == "NOTHING")
       {
          Console.WriteLine("The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.THE END. >:^)");
          return;
      } else
      {
          Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
          return;
      }
    } else if (doorChoice == "OPEN")
    {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
        switch (keyChoice) {
          
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. Strange... \nTHE END. >:^)");
              return;
            

            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. \nTHE END. (lel)");
              return;
            

            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. >womp womp< \nTHE END.");
              return;
            

            default:
               Console.WriteLine("We're NOT playing this game. Make a proper selection or you're done");
              
               
                Console.WriteLine("The door is locked! See if one of your three keys will open it. \nLet's see if we can't get it right this time.");
               Console.Write("Enter a number (1-3): ");
                keyChoice = Console.ReadLine();
        switch (keyChoice) {
          
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. Strange... \nTHE END. >:^)");
              return;
            

            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. \nTHE END. (lel)");
              return;
            

            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. >womp womp< \nTHE END.");
              return;
            

            default:
                  Console.WriteLine("alright stupid just lose then lulz");
                  return;
       }
     }
    } else
    {
         Console.WriteLine("Type OPEN or KNOCK (It's quite taxxing to do these super redundant if/elses so please lets get things right the first try from now on):  ");
         doorChoice = Console.ReadLine();
         doorChoice = doorChoice.ToUpper();

        if (doorChoice == "KNOCK")
    {
        Console.WriteLine("A voice behind the door speaks. It says," + " Answer this riddle: " + "\n" + "Poor people have it. Rich people need it. If you eat it you die. What is it?");
        Console.Write("Type your answer: ");
      string riddleAnswer = Console.ReadLine();
      riddleAnswer = riddleAnswer.ToUpper();
      if (riddleAnswer == "NOTHING")
       {
          Console.WriteLine("The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.THE END. >:^)");
          return;
      } else
      {
          Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
          return;
      }
    }   else if (doorChoice == "OPEN")
    {
       Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
        switch (keyChoice) {
          
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. Strange... \nTHE END. >:^)");
              return;
            

            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. \nTHE END. (lel)");
              return;
            

            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. >womp womp< \nTHE END.");
              return;
            

            default:
               Console.WriteLine("We're NOT playing this game. Make a proper selection or you're done");
          
               
                Console.WriteLine("The door is locked! See if one of your three keys will open it. \nLet's see if we can't get it right this time.");
               Console.Write("Enter a number (1-3): ");
                keyChoice = Console.ReadLine();
        switch (keyChoice) {
          
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. Strange... \nTHE END. >:^)");
              break;
            

            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. \nTHE END. (lel)");
              break;
            

            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. >womp womp< \nTHE END.");
              break;
            

            default:
                  Console.WriteLine("alright stupid just lose then lulz");
                  break;
        }
     }
    } else
    {
      Console.WriteLine("YOU LOSE, YOU SUCK, YOU HAVE AIDS, JUST QUIT \n G A M E  O V E R (scrub)");
      
    }
  } 
}
    





    }
  }
}
