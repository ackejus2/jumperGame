class Program{
    static void Main(string[] args){
        wordList randomWord = new wordList();
        string word = randomWord.pull_random_word();
        Guess newGuess = new Guess(word);
        int missedLetters = 0;
        dynamicAnimation dynAn = new dynamicAnimation();
        staticAnimation statAn = new staticAnimation();
        string oldGuessLine = "_____";
        Console.WriteLine("\nThe game is to guess a 5 letter word! \nYou have 5 segments of your parachute!");
        Console.WriteLine("Each wrong guess you make, you lose a piece of your chute!");
        Console.WriteLine("When your chute is gone, you lose!\nHave fun!");

        while (missedLetters < 5 && oldGuessLine != word){
            Console.WriteLine("\nGuess a letter [a-z]: ");
            string? stringGuess = Console.ReadLine();
            char charGuess = Convert.ToChar(stringGuess);
            newGuess.user_guess(charGuess);
            string newGuessLine = newGuess.getUnknown();
            if (oldGuessLine == newGuessLine){
                missedLetters += 1;
            }
            Console.WriteLine($"Guess: {newGuessLine}");
            oldGuessLine = newGuessLine;
            dynAn.drawParachute(missedLetters);
            statAn.drawGround();
            Console.WriteLine($"Number of Wrong Guesses: {missedLetters}");
            
            }

        if(missedLetters == 5){
        dynAn.drawParachute(missedLetters);
        statAn.drawGround();
        Console.WriteLine("You died. Please try again!");
        Console.WriteLine($"The word you missed: {word}");
        }
        else if(oldGuessLine == word){
        Console.WriteLine("You won! Congratulations!");
        Console.WriteLine("You made it to the ground!");
        }
        }
}
        //determine if player is crrect
        //if they are remove letter and draw letter on screen
        //if not then call on animation to remove a life state

        //loop till word is done or out of lives
        //if pplayer finisnhes a word end or do we want it to loop back witha play again?
    



    
