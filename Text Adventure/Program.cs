using System.Runtime.InteropServices;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is a dark stormy night");
            Thread.Sleep(2000);
            Console.WriteLine("You're in the middle of the sea just in a small sail boat");
            Thread.Sleep(2000);
            Console.WriteLine("The waves get more and more catastrophic makeing the boat less stable");
            Thread.Sleep(2000);
            Console.WriteLine("Next thing you know you're pulled under the water by a massive wave");
            Thread.Sleep(2000);
            Console.WriteLine("When you wake up you're somewhere you don't know");
            Thread.Sleep(2000);
            Console.WriteLine("You're stranded on an island with limited resources");
            Thread.Sleep(2000);
            Console.WriteLine("Can you survive long enough until help arrives?");
            Thread.Sleep(2000);
            Console.WriteLine("Type 'Start' to play");

            string input = Console.ReadLine();
            if (input == "Start")
            {
                Console.WriteLine("You are stranded with limited recorces. what should you do first?");
                Thread.Sleep(2000);
                Console.WriteLine("A) Scream for help");
                Thread.Sleep(2000);
                Console.WriteLine("B) Search for recorces to survive");
                Thread.Sleep(2000);

                input = Console.ReadLine();
                if (input == ("A"))
                {
                    Console.WriteLine("You scream for a long time but no help comes");
                    Thread.Sleep(2000);
                    Console.WriteLine("Next thing you know a bear hears you screaming");
                    Thread.Sleep(2000);
                    Console.WriteLine("What do you do?");
                    Thread.Sleep(2000);

                    Console.WriteLine("A) Run away screaming");
                    Thread.Sleep(2000);
                    Console.WriteLine("B) Make yourself tall and big to scare off the bear");
                    Thread.Sleep(2000);

                    input = Console.ReadLine();
                    if (input == "A")
                    {
                        Console.WriteLine("You runaway screaming, but the bear chases you");
                        Thread.Sleep(2000);
                        Console.WriteLine("The bear catches up to you and kills you");
                        Thread.Sleep(2000);

                    }
                    if (input == "B")
                    {
                        Console.WriteLine("You make yourself look bigger than the bear");
                        Thread.Sleep(2000);
                        Console.WriteLine("The bear runs off, you survive");
                        Thread.Sleep(2000);
                        Console.WriteLine("Type 'Continue' to proceed in the game");
                        Thread.Sleep(2000);
                    }

                    input = Console.ReadLine();
                    if (input == ("Continue"))
                    {
                        Console.WriteLine("You go and search for resoruces, as screaming won't do anything");
                        Thread.Sleep(2000);
                        Console.WriteLine("The island luckily has multiple food sources");
                        Thread.Sleep(2000);
                        Console.WriteLine("What food should you go after");
                        Thread.Sleep(2000);

                        Console.WriteLine("A) Red berries");
                        Thread.Sleep(2000);
                        Console.WriteLine("B) Bananas");
                        Thread.Sleep(2000);
                        Console.WriteLine("C) Fish");
                        Thread.Sleep(2000);

                        input = Console.ReadLine();
                        if(input == "A")
                        {
                            Console.WriteLine("You eat a bunch of red berries you found");
                            Thread.Sleep(2000);
                            Console.WriteLine("They look questionable, but you don't pay attention to that");
                            Thread.Sleep(2000);
                            Console.WriteLine("After a while you start feeling really sick");
                            Thread.Sleep(2000);
                            Console.WriteLine("You wonder why you feel like this");
                            Thread.Sleep(2000);
                            Console.WriteLine("You realize that the berries you ate are posionous");
                            Thread.Sleep(2000);
                            Console.WriteLine("However, you can't do anything stranded here");
                            Thread.Sleep(2000);
                            Console.WriteLine("After a while you die of food poisoning");
                            Thread.Sleep(2000);
                        }

                        input = Console.ReadLine();
                        if (input == "B")
                        {
                            Console.WriteLine("You go and search for bananas");
                            Thread.Sleep(2000);
                            Console.WriteLine("You find some in a tree, but they are high up");
                            Thread.Sleep(2000);
                            Console.WriteLine("How will you reach the bananas");
                            Thread.Sleep(2000);

                            Console.WriteLine("A) Try and shake them down");
                            Thread.Sleep(2000);
                            Console.WriteLine("B) Climb the tree");
                            Thread.Sleep(2000);

                            input = Console.ReadLine();
                            if (input == "A")
                            {
                                Console.WriteLine("You try and shake down the bananas, but they are really strong");
                                Thread.Sleep(2000);
                                Console.WriteLine("The bananas won't come down");
                                Thread.Sleep(2000);
                                Console.WriteLine("Maybe you should try something else");
                                Thread.Sleep(2000);
                            }

                            input = Console.ReadLine();
                            if (input == "B")
                            {
                                Console.WriteLine("You decide to take inspiraiton from the monkeys and climb it");
                                Thread.Sleep(2000);
                                Console.WriteLine("You climb until you get to the top and grab the bananas");
                                Thread.Sleep(2000);
                                Console.WriteLine("You carefully climb down and enjoy the bananas");
                                Thread.Sleep(2000);
                                Console.WriteLine("Type 'Continue' to proceed");
                            }

                            input = Console.ReadLine();
                            if (input == "Continue")
                            {
                                Console.WriteLine("What should you do next?");
                                Thread.Sleep(2000);

                                Console.WriteLine("A) Explore");
                                Thread.Sleep(2000);
                                Console.WriteLine("B) Bulid something so a ship nearby sees it");
                                Thread.Sleep(2000);

                                input= Console.ReadLine();
                                if(input == "A")
                                {
                                    Console.WriteLine("You decide to expore, as the big island seems intresting");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("After a while you stumble across a cave");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You decide to enter the cave, as it seems very mysterious");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You luckily have a flashlight with you somehow");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("As you go deeper, you find a tresure chest");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You decide to open the chest");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("There is many tresures in the chest");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You take them back with you");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("When you head back you see a ship pass by");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("It notices you and comes to help");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You go back and with the tresures you become rich");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Maybe being stranded wasn't that bad after all");
                                    Thread.Sleep(2000);
                                }

                                input = Console.ReadLine();
                                if (input == "B")
                                {
                                    Console.WriteLine("You decide to make a something to help ships notice you");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You build out something that says 'SOS'");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Not too long later to your suprise, you are saved");
                                    Thread.Sleep(2000);
                                }
                            }

                            input= Console.ReadLine();
                            if (input == "C")
                            {
                                Console.WriteLine("You decide to go fishing");
                                Thread.Sleep(2000);
                                Console.WriteLine("Luckily after the shipwreck your fishing rod was there");
                                Thread.Sleep(2000);
                                Console.WriteLine("You manage to catch a fish, but now you need a fire to cook it");
                                Thread.Sleep(2000);
                                Console.WriteLine("What should you do?");
                                Thread.Sleep(2000);

                                Console.WriteLine("A) rub two sticks together to make fire");
                                Thread.Sleep(2000);
                                Console.WriteLine("B) Find something to reflect the heat of the sun");
                                Thread.Sleep(2000);

                                input = Console.ReadLine();
                                if (input == "A")
                                {
                                    Console.WriteLine("You decide to do it the classic way, Rubbing two sticks together");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You realize this method takes a really long time");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("It does work, but it is almost dark");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You decide after eating the fish you should sleep");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You wake up the next day and realize you are back in your bedroom");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Everything from today was just a dream");
                                }

                                input = Console.ReadLine();
                                if (input == "B")
                                {
                                    Console.WriteLine("You decide to be an epic genius and use something to reflect the sunlight");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You find a glass bottle from when the shipwreck happened");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("You use it to reflect the light on some wood");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("The wood lights on fire and you cook your fish");
                                    Thread.Sleep(2000);
                                }







                            }
                        }


                    }

                }

                input = Console.ReadLine();
                if(input == ("B"))
                {
                    Console.WriteLine("You go and search for resoruces, as screaming won't do anything");
                    Thread.Sleep(2000);
                    Console.WriteLine("The island luckily has multiple food sources");
                    Thread.Sleep(2000);
                    Console.WriteLine("What food should you go after");
                    Thread.Sleep(2000);

                    Console.WriteLine("A) Red berries");
                    Thread.Sleep(2000);
                    Console.WriteLine("B) Bananas");
                    Thread.Sleep(2000);
                    Console.WriteLine("C) Fish");
                    Thread.Sleep(2000);
                    
                    input = Console.ReadLine();
                    if (input=="A")
                    {
                        Console.WriteLine("You eat a bunch of red berries you found");
                        Thread.Sleep(2000);
                        Console.WriteLine("They look questionable, but you don't pay attention to that");
                        Thread.Sleep(2000);
                        Console.WriteLine("After a while you start feeling really sick");
                        Thread.Sleep(2000);
                        Console.WriteLine("You wonder why you feel like this");
                        Thread.Sleep(2000);
                        Console.WriteLine("You realize that the berries you ate are posionous");
                        Thread.Sleep(2000);
                        Console.WriteLine("However, you can't do anything stranded here");
                        Thread.Sleep(2000);
                        Console.WriteLine("After a while you die of food poisoning");
                        Thread.Sleep(2000);
                    }

                    input = Console.ReadLine();
                    if(input== "B")
                    {
                        Console.WriteLine("You go and search for bananas");
                        Thread.Sleep(2000);
                        Console.WriteLine("You find some in a tree, but they are high up");
                        Thread.Sleep(2000);
                        Console.WriteLine("How will you reach the bananas");
                        Thread.Sleep(2000);

                        Console.WriteLine("A) Try and shake them down");
                        Thread.Sleep(2000);
                        Console.WriteLine("B) Climb the tree");
                        Thread.Sleep(2000);

                        input = Console.ReadLine();
                        if (input == "A")
                        {
                            Console.WriteLine("You try and shake down the bananas, but they are really strong");
                            Thread.Sleep(2000);
                            Console.WriteLine("The bananas won't come down");
                            Thread.Sleep(2000);
                            Console.WriteLine("Maybe you should try something else");
                            Thread.Sleep(2000);
                        }

                        input = Console.ReadLine();
                        if (input == "B")
                        {
                            Console.WriteLine("You decide to take inspiraiton from the monkeys and climb it");
                            Thread.Sleep(2000);
                            Console.WriteLine("You climb until you get to the top and grab the bananas");
                            Thread.Sleep(2000);
                            Console.WriteLine("You carefully climb down and enjoy the bananas");
                        }

                    }

                    input = Console.ReadLine();
                    if(input == "C")
                    {
                        Console.WriteLine("You decide to go fishing");
                        Thread.Sleep(2000);
                        Console.WriteLine("Luckily after the shipwreck your fishing rod was there");
                        Thread.Sleep(2000);
                        Console.WriteLine("You manage to catch a fish, but now you need a fire to cook it");
                        Thread.Sleep(2000);
                        Console.WriteLine("What should you do?");
                        Thread.Sleep(2000);

                        Console.WriteLine("A) rub two sticks together to make fire");
                        Thread.Sleep(2000);
                        Console.WriteLine("B) Find something to reflect the heat of the sun");
                        Thread.Sleep(2000);

                        input = Console.ReadLine();
                        if (input == "A")
                        {
                            Console.WriteLine("You decide to do it the classic way, Rubbing two sticks together");
                            Thread.Sleep(2000);
                            Console.WriteLine("You realize this method takes a really long time");
                            Thread.Sleep(2000);
                            Console.WriteLine("It does work, but it is almost dark");
                            Thread.Sleep(2000);
                            Console.WriteLine("You decide after eating the fish you should sleep");
                            Thread.Sleep(2000);
                            Console.WriteLine("You wake up the next day and realize you are back in your bedroom");
                            Thread.Sleep(2000);
                            Console.WriteLine("Everything from today was just a dream");
                        }

                        input = Console.ReadLine();
                        if (input == "B")
                        {
                            Console.WriteLine("You decide to be an epic genius and use something to reflect the sunlight");
                            Thread.Sleep(2000);
                            Console.WriteLine("You find a glass bottle from when the shipwreck happened");
                            Thread.Sleep(2000);
                            Console.WriteLine("You use it to reflect the light on some wood");
                            Thread.Sleep(2000);
                            Console.WriteLine("The wood lights on fire and you cook your fish");
                            Thread.Sleep(2000);
                            Console.WriteLine("What should you do next?");
                            Thread.Sleep(2000);

                            Console.WriteLine("A) Explore");
                            Thread.Sleep(2000);
                            Console.WriteLine("B) Bulid something so a ship nearby sees it");
                            Thread.Sleep(2000);

                            input = Console.ReadLine();
                            if (input == "A") 
                            {
                                Console.WriteLine("You decide to expore, as the big island seems intresting");
                                Thread.Sleep(2000);
                                Console.WriteLine("After a while you stumble across a cave");
                                Thread.Sleep(2000);
                                Console.WriteLine("You decide to enter the cave, as it seems very mysterious");
                                Thread.Sleep(2000);
                                Console.WriteLine("You luckily have a flashlight with you somehow");
                                Thread.Sleep(2000);
                                Console.WriteLine("As you go deeper, you find a tresure chest");
                                Thread.Sleep(2000);
                                Console.WriteLine("You decide to open the chest");
                                Thread.Sleep(2000);
                                Console.WriteLine("There is many tresures in the chest");
                                Thread.Sleep(2000);
                                Console.WriteLine("You take them back with you");
                                Thread.Sleep(2000);
                                Console.WriteLine("When you head back you see a ship pass by");
                                Thread.Sleep(2000);
                                Console.WriteLine("It notices you and comes to help");
                                Thread.Sleep(2000);
                                Console.WriteLine("You go back and with the tresures you become rich");
                                Thread.Sleep(2000);
                                Console.WriteLine("Maybe being stranded wasn't that bad after all");
                                Thread.Sleep(2000);
                            
                            }

                            input = Console.ReadLine();
                            if (input == "B")
                            {
                                Console.WriteLine("You decide to make a something to help ships notice you");
                                Thread.Sleep(2000);
                                Console.WriteLine("You build out something that says 'SOS'");
                                Thread.Sleep(2000);
                                Console.WriteLine("Not too long later to your suprise, you are saved");
                                Thread.Sleep(2000);
                            }



                        }



                    }

                    

                }

              

































                













            }

           






        }




    }
}




























