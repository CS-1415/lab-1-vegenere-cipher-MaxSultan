// Max Sultan, January 18th 2026, Lab 1 Venegere Cipher

using System.Diagnostics;
using System.Linq;

static void TestIsLowercaseLetter() 
{
    Debug.Assert(IsLowercaseLetter('a'));
    Debug.Assert(IsLowercaseLetter('b'));
    Debug.Assert(IsLowercaseLetter('z'));
    Debug.Assert(!IsLowercaseLetter('A'));
    Debug.Assert(!IsLowercaseLetter('`'));
    Debug.Assert(!IsLowercaseLetter('{'));
}

void TestIsValidInput() 
{
    Debug.Assert(IsValidInput("thisisvalidinput"));
    Debug.Assert(IsValidInput("this should be valid"));
    Debug.Assert(IsValidInput("this is valid input also"));
    Debug.Assert(!IsValidInput("ThisIsNotValid"));
    Debug.Assert(!IsValidInput("`notValid`"));
    Debug.Assert(!IsValidInput("WHAT"));
}

static bool IsLowercaseLetter(char c) 
{
    return Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122 || Convert.ToInt32(c) == 32;
}

bool IsValidInput(string input)
{
    return input.ToCharArray().All(IsLowercaseLetter);
}

TestIsLowercaseLetter();
TestIsValidInput();

Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.");
Console.WriteLine("Please enter the message:");
string message = Console.ReadLine();
Console.WriteLine("Please enter an encryption key:");
string key = Console.ReadLine();
string encryptedMessage = message;
Console.WriteLine("Here is the encrypted message: ");
Console.WriteLine(encryptedMessage);