class dynamicAnimation {
    public void drawParachute(int missedLetters) {
        if (missedLetters == 0) {
            Console.WriteLine("  ___ ");
            Console.WriteLine(" /   \\");
            Console.WriteLine("  ___ ");
            Console.WriteLine(" \\   /");
            Console.WriteLine("  \\ /");
            Console.WriteLine("   o  ");
        }
        else if (missedLetters == 1) {
            Console.WriteLine(" /   \\");
            Console.WriteLine("  ___ ");
            Console.WriteLine(" \\   /");
            Console.WriteLine("  \\ /");
            Console.WriteLine("   o  ");
        }
        else if (missedLetters == 2) {
            Console.WriteLine("  ___ ");
            Console.WriteLine(" \\   /");
            Console.WriteLine("  \\ /");
            Console.WriteLine("   o  ");
        }
        else if (missedLetters == 3) {
            Console.WriteLine(" \\   /");
            Console.WriteLine("  \\ /");
            Console.WriteLine("   o  ");
        }
        else if (missedLetters == 4) {
            Console.WriteLine("  \\ /");
            Console.WriteLine("   o  ");
            ;
        }
        else if (missedLetters == 5) {
            Console.WriteLine("");
            Console.WriteLine("   x  ");
        }
    }
}