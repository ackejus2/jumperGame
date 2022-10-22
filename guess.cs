public class Guess {
    char[] unknown = {'_', '_', '_', '_', '_'};
    string word = "treat";
    // need to pull the name that we used in the main program
    
    public Guess(string randWord){
        word = randWord;
    }

    public void user_guess(char guessIn){
        for (int i = 0 ; i < word.Length; i++){
        if (word[i] == guessIn) {
            unknown[i] = guessIn;
        }
        }
    }

    public string getUnknown(){
        // return a string from the unknown list
        string wordString = String.Join("", unknown);
        return wordString;
            }


}