// Max Sultan, January 18th 2026, Lab 1 Venegere Cipher

using System.Diagnostics;

static void TestIsLowercaseLetter() {
    Debug.Assert(IsLowercaseLetter('a'));
    Debug.Assert(IsLowercaseLetter('b'));
    Debug.Assert(IsLowercaseLetter('z'));
    Debug.Assert(!IsLowercaseLetter('A'));
    Debug.Assert(!IsLowercaseLetter('`'));
    Debug.Assert(!IsLowercaseLetter('{'));
}

static bool IsLowercaseLetter(char c) {
    return System.Convert.ToInt32(c) >= 97 && System.Convert.ToInt32(c) <= 122;
}

TestIsLowercaseLetter();

Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.");
Console.WriteLine("Please enter the message:");
string message = Console.ReadLine();
Console.WriteLine("Please enter an encryption key:");
string key = Console.ReadLine();
string encryptedMessage = message;
Console.WriteLine("Here is the encrypted message: ");
Console.WriteLine(encryptedMessage);