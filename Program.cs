class Program{
    static void Main(string[] args){
        wordList randomWord = new wordList();
        string word = randomWord.pull_random_word();
        Guess newGuess = new Guess(word);
        int missedLetters = 0;
        dynamicAnimation dynAn = new dynamicAnimation();
        staticAnimation statAn = new staticAnimation();
        string oldGuessLine = "-----";

        while (missedLetters < 5){
            Console.WriteLine("Guess a letter [a-z]: ");
            string? stringGuess = Console.ReadLine();
            char charGuess = Convert.ToChar(stringGuess);
            newGuess.user_guess(charGuess);
            string newGuessLine = newGuess.getUnknown();
            Console.WriteLine(newGuessLine);
            dynAn.drawParachute(missedLetters);
            statAn.drawGround();
            if (oldGuessLine == newGuessLine){
                missedLetters += 1;
            }
            oldGuessLine = newGuessLine;
            }

        dynAn.drawParachute(missedLetters);
        statAn.drawGround();
        Console.Write("You died. Please try again!");
        Console.WriteLine($"The word you missed: {word}");
        }
        }
        //determine if player is crrect
        //if they are remove letter and draw letter on screen
        //if not then call on animation to remove a life state

        //loop till word is done or out of lives
        //if pplayer finisnhes a word end or do we want it to loop back witha play again?
    



    
