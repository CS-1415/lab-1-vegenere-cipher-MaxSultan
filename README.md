# Lab-1-Vigenere-Cipher




Vigenere Cipher
General Learning Objectives

Use a modern operating system and utilities.

Use an integrated development environment to develop a program.

Solve problems and develop programs using the control structures of sequence, selection, and repetition, following a disciplined approach.

Goals
Recall (or learn) how writing simple tests can help you clearly understand, specify, and achieve desired behavior.
Write a cool program to review standard procedural programming (i.e. not object-oriented) in C#.
Overview

You will use standard procedural programming to make a program that lets you encrypt messages while reviewing several basics of programming and C#. Here are a couple of sample runs of the final program. Run 1:

This program encrypts the characters of a message using the Vigenere method.
Please enter the message:
        endzz
Please enter an encryption key:
        b
Here is the encrypted message:
        foeaa


Since there was only a single character in the encryption key, each character of the input will be shifted by the same number of characters. In this case, 'b' is at position 1 in the alphabet, so the 'e' in the input was shifted to the next letter, 'f', in the output. Note that 'z' wrapped around to 'a'. In the following example, there are two characters in the key: 'bc' which are at positions 1 and 2 in the alphabet. Since the input message is longer than the key, the key is used repeatedly as if it had been 'bcbcb'.

This program encrypts the characters of a message using the Vigenere method.
Please enter the message:
        endzz
Please enter an encryption key:
        bc
Here is the encrypted message:
        fpeba


To keep things simple, you should require that the message and the key only contain lower-case letters as demonstrated in the following examples:

This program encrypts the characters of a message using the Vigenere method.
Please enter the message:
        message with a space
Sorry, we only support lower-case letters.

This program encrypts the characters of a message using the Vigenere method.
Please enter the message:
        messagewithnospace
Please enter an encryption key:
        OrKeyWithCapitals
Sorry, we only support lower-case letters.

Setup
Make sure that you can compile and run C# code on your local computer (I suggest VS Code as a good, free editor).
If you've never done any automated testing in C#: take a look at Using Assert and Test-Driven Development (TDD).
Accept the assignment from GitHub Classrooms.  Use the clone of this assignment to submit your final project.
Steps
Write a program that asks the user for a message and key and displays the message as above (message need not be encrypted for these points).
Write a documented stub for a static method that accepts a character and returns true if it is a lowercase letter and false otherwise (this one done for you):
// Returns true if the given character is a lowercase letter and false otherwise
public static bool IsLowercaseLetter(char c) {
    return false;
}

Write a test with at least one assertion showing when that method should return true and at least one showing when it should return false (this one done for you, too!):
using System.Diagnostics.Debug;

public static void TestIsLowercaseLetter() {
    Debug.Assert(TestIsLowercaseLetter('a'));
    Debug.Assert(TestIsLowercaseLetter('b'));
    Debug.Assert(TestIsLowercaseLetter('z'));
    Debug.Assert(!TestIsLowercaseLetter('A'));
    Debug.Assert(!TestIsLowercaseLetter('`'));
    Debug.Assert(!TestIsLowercaseLetter('{'));
}

Implement your IsLowercaseLetter method (now your tests should pass).
Write a documented stub for a static method that accepts a string and returns true if it is valid (i.e. only made up of lowercase letters).
Write a test with at least one assertion showing when that method should return true and at least one showing when it should return false.
Implement your IsValidInput method. See your tests pass.
Write a documented stub for a static method that accepts two characters (one from the message and one from the key) and returns the appropriate shifted character.
Write a test with at least 2 separate inputs showing the expected results.
Implement your ShiftLetter method. See your tests pass.
Write a documented stub for a static method that accepts two strings (the message and the key) and returns a the encoded message.
Write a test with at least 2 separate inputs showing the expected results.
Implement your ShiftMessage method. See your tests pass.
Have your main driver validate the input message; validate the key; and print out the encrypted message (see examples above).
Bonus (not required): modify your program to support messages and keys with any ascii characters between 32 and 126 (inclusive) without changing the functionality on lowercase letters.
Rubric
[
    {"label": "Comment at top of Program.cs giving your name(s), the date, and the name of the lab", "points": 1},
    {"label": "Greeting describing to the user the purpose of the program", "points": 1},
    {"label": "Program accepts message and key and prints out (possibly encrypted) message", "points": 2},
    {"label": "Working signature for IsLowercaseLetter", "points": 1},
    {"label": "At least 2 auto tests for IsLowercaseLetter", "points": 1},
    {"label": "Working implementation for IsLowercaseLetter", "points": 2},
    {"label": "Working signature for IsValidInput", "points": 1},
    {"label": "At least 2 auto tests for IsValidInput", "points": 1},
    {"label": "Working implementation for IsValidInput", "points": 2},
    {"label": "Working signature for ShiftLetter", "points": 1},
    {"label": "At least 2 auto tests for ShiftLetter", "points": 1},
    {"label": "Working implementation for ShiftLetter", "points": 2},
    {"label": "Working signature for ShiftMessage", "points": 1},
    {"label": "At least 2 auto tests for ShiftMessage", "points": 1},
    {"label": "Working implementation for ShiftMessage", "points": 2},
    {"label": "Main driver correctly validates user input, showing error message if invalid or showing encrypted message if valid.", "points": 3},
    {"label": "Well-named classes, functions, and variables", "points": 1},
    {"label": "Clean and consistent vertical whitespace.  Leave one line between functions, leave blank lines between logically grouped blocks of code, etc.", "points": 1},
    {"label": "(5 points bonus) Appropriate handling of other characters without breaking required behavior", "points": 0}
]