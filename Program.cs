using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(OldPhonePadConverter.OldPhonePad("33#"));                      // E
        Console.WriteLine(OldPhonePadConverter.OldPhonePad("227#"));                     // B
        Console.WriteLine(OldPhonePadConverter.OldPhonePad("4433555 555666#"));          // HELLO
        Console.WriteLine(OldPhonePadConverter.OldPhonePad("8888888 88777444666*664#"));       // TURING
    }
}
