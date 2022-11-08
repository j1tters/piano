

class Program
{
    static void playSound(int hz)
    {
        Console.Beep(hz, 200);
    }
    static int[] getOctave(int octaveNum)
    {
       
        // C   C#  D   Eb  E   F   F#  G   G#  А   Bb  B
        // int[] octave = new int[] {16,       17,     18,     19,     20,     21,     23,     24,     25,     27,     29,     30};
        int[] octave = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        switch (octaveNum)
        {
            case 1:
                // octave = new int[] {30,     34,     36,     38,     41,     43,     46,     49,     51,     55,     58,     61};
                break;
            case 2:
                // octave = new int[] {65,     69,     73,     77,     82,     87,     92,     98,     103,    110,    116,    123};
                break;
            case 3:
                octave = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
                break;
            case 4:
                octave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                break;
            case 5:
                octave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                break;
            case 6:
                octave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                break;
            case 7:
                octave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                break;
            case 8:
                octave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                break;
        }
        return octave;
    }
    static void Main()
    {
        Console.Clear();
        Console.WriteLine(@"Клавиши:
        F1..F9 - переключение октав.
        Q..] - клавиши.
        Esc - выход.
        Сначала нажмите октаву, потом клавишу.");
        for (; ; )
        {
            int octaveNum = 0;
            ConsoleKeyInfo octaveKI = Console.ReadKey(true);
            switch (octaveKI.Key)
            {
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F2:
                    octaveNum = 1;
                    break;
                case ConsoleKey.F3:
                    octaveNum = 2;
                    break;
                case ConsoleKey.F4:
                    octaveNum = 3;
                    break;
                case ConsoleKey.F5:
                    octaveNum = 4;
                    break;
                case ConsoleKey.F6:
                    octaveNum = 5;
                    break;
                case ConsoleKey.F7:
                    octaveNum = 6;
                    break;
                case ConsoleKey.F8:
                    octaveNum = 7;
                    break;
                case ConsoleKey.F9:
                    octaveNum = 8;
                    break;
                default:
                    Console.WriteLine("Нет такой октавы. Выбрана 1я октава.");
                    break;
            }
            int[] octave = getOctave(octaveNum);
            ConsoleKeyInfo ki = Console.ReadKey(true);
            switch (ki.Key)
            {
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.Q:
                    playSound(octave[0]);
                    break;
                case ConsoleKey.W:
                    playSound(octave[1]);
                    break;
                case ConsoleKey.E:
                    playSound(octave[2]);
                    break;
                case ConsoleKey.R:
                    playSound(octave[3]);
                    break;
                case ConsoleKey.T:
                    playSound(octave[4]);
                    break;
                case ConsoleKey.Y:
                    playSound(octave[5]);
                    break;
                case ConsoleKey.U:
                    playSound(octave[6]);
                    break;
                case ConsoleKey.I:
                    playSound(octave[7]);
                    break;
                case ConsoleKey.O:
                    playSound(octave[8]);
                    break;
                case ConsoleKey.P:
                    playSound(octave[9]);
                    break;
                case ConsoleKey.Oem4:
                    playSound(octave[10]);
                    break;
                case ConsoleKey.Oem5:
                    playSound(octave[11]);
                    break;
                default:
                    Console.WriteLine("Нет такой клавиши. Начните сначала.");
                    break;
            }
        }
    }
}