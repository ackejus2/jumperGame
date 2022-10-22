class Program{
    static void Main(string[] args){
        var playerIsAlive = true;
        wordList randomWord = new wordList();
        string word = randomWord.pull_random_word();
        Guess newGuess = new Guess();

        while (playerIsAlive){
            Console.WriteLine("Guess a letter [a-z]: ");
            string? stringGuess = Console.ReadLine();
            char charGuess = Convert.ToChar(stringGuess);
            newGuess.user_guess(charGuess);
            string guessLine = getUnknown();
            

    }
        //determine if player is crrect
        //if they are remove letter and draw letter on screen
        //if not then call on animation to remove a life state

        //loop till word is done or out of lives
        //if pplayer finisnhes a word end or do we want it to loop back witha play again?
    
}}


    
