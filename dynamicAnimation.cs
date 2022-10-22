class dynamicAnimation {
    int missedLetters = 0;
    public void drawParachute() {
        if (missedLetters == 0) {
            Console.WriteLine(" ___ ");
            Console.WriteLine("/   \\");
            Console.WriteLine(" ___ ");
            Console.WriteLine("\\   /");
            Console.WriteLine("\\ /");
        }
        else if (missedLetters == 1) {
            Console.WriteLine("/   \\");
            Console.WriteLine(" ___ ");
            Console.WriteLine("\\   /");
            Console.WriteLine("\\ /");
        }
        else if (missedLetters == 2) {
            Console.WriteLine(" ___ ");
            Console.WriteLine("\\   /");
            Console.WriteLine("\\ /");
        }
        else if (missedLetters == 3) {
            Console.WriteLine("\\   /");
            Console.WriteLine("\\ /");
        }
        else if (missedLetters == 4) {
            Console.WriteLine("\\ /");
        }
        else if (missedLetters == 5) {
            Console.WriteLine("");
        }
    }
    public void drawHead() {
        var playerIsAlive = true;
        var playerIsDead = false;
        if (playerIsAlive){
            Console.WriteLine("  o  ");
        }
        else if (playerIsDead){
            Console.WriteLine("  x  ");
        }
    }
}