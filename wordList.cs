public class wordList {

    private List<string> ListOfWords = new List<string>();

    public wordList(){
        ListOfWords.Add("ghost");
        ListOfWords.Add("treat");
        ListOfWords.Add("candy");
        ListOfWords.Add("haunt");
        ListOfWords.Add("trick");
    }

    private wordList ListSpookyWords = new wordList();
    private Random generator = new Random();
    public string pull_random_word(){ 
        
        int randIndex = generator.Next(ListSpookyWords.ListOfWords.Count);
        string random_word = ListOfWords[randIndex];
        ListOfWords.RemoveAt(randIndex);
        return random_word;
    } 
}
