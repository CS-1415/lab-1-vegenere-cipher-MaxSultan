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

static void TestIsValidInput() 
{
    Debug.Assert(IsValidInput("thisisvalidinput"));
    Debug.Assert(!IsValidInput("ThisIsNotValid"));
    Debug.Assert(!IsValidInput("`notValid`"));
    Debug.Assert(!IsValidInput("this is not valid"));
}

static void TestClamp()
{
    Debug.Assert(Clamp(97, 122, 130) == 104);
    Debug.Assert(Clamp(97, 122, 97) == 97); 
    Debug.Assert(Clamp(97, 122, 122) == 122); 
    Debug.Assert(Clamp(97, 122, 123) == 97); 
}

static void TestShiftLetter()
{
    Debug.Assert(ShiftLetter('a','a') == 'a');
    Debug.Assert(ShiftLetter('z','b') == 'a');
    Debug.Assert(ShiftLetter('a','b') == 'b');
    Debug.Assert(ShiftLetter('g','z') == 'f');
}

static void TestShiftMessage()
{
    Debug.Assert(ShiftMessage("endzz", "bc") == "fpeba");
    Debug.Assert(ShiftMessage("endzz", "b") == "foeaa");
}


static bool IsLowercaseLetter(char c) 
{
    return Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122;
}

static bool IsValidInput(string input)
{
    return input.ToCharArray().All(IsLowercaseLetter);
}

static int Clamp(int min, int max, int number)
{
    if (number > max)
        return Clamp(min, max, number - max - 1);
    else if (number < min)
        return Clamp(min, max, number + min);
    else
        return number;
}

static char ShiftLetter(char c, char shift)
{
    int shiftFactor = Convert.ToInt32(shift) - 97;
    return (char)Clamp(97, 122, Convert.ToInt32(c) + shiftFactor);
}

static string ShiftMessage(string message, string key)
{
    int keyLength = key.Length;
    string result = "";
    for (int i = 0; i < message.Length; i++)
    {
        int keyIndex = i % keyLength;
        result += ShiftLetter(message[i], key[keyIndex]);
    }
    return result;
}

TestIsLowercaseLetter();
TestIsValidInput();
TestClamp();
TestShiftLetter();
TestShiftMessage();

void Main(){
    Console.WriteLine("This program encrypts the characters of a message using the Vigenere method.");
    Console.WriteLine("Please enter the message:");
    string message = Console.ReadLine();
    if (!IsValidInput(message))
    {
        Console.WriteLine("Sorry, we only support lower-case letters.");
        return;
    }
    if (message == "")
    {
        Console.WriteLine("You must enter some characters");
        return; 
    }  
    Console.WriteLine("Please enter an encryption key:");
    string key = Console.ReadLine();
    if (!IsValidInput(key))
    {
        Console.WriteLine("Sorry, we only support lower-case letters.");
        return;
    }
    if (key == "")
    {
        Console.WriteLine("You must enter some characters");
        return; 
    }  
    string encryptedMessage = ShiftMessage(message, key);
    Console.WriteLine("Here is the encrypted message: ");
    Console.WriteLine(encryptedMessage);
}

Main();