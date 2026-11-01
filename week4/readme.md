Chapter 04: Loops, Files, and Random Numbers

Introduction

This chapter explains how to use loops, work with files, generate random numbers, and use the Load Event in C# Windows Forms applications.

1. The While Loop

Theory

A while loop repeats a statement or group of statements as long as a Boolean condition is true.

It is a Pretest Loop, meaning the condition is checked before the loop executes.

Syntax

while (condition)
{
    // Statements
}

Example

int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}

Explanation:

* int count = 0: Initializes the counter.
* count < 5: Checks the condition.
* MessageBox.Show: Displays a message.
* count++: Increases the counter by 1.

The loop executes 5 times.

Infinite Loop

An infinite loop happens when the condition never becomes false.

int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
}

The problem is that count is never increased.

⸻

2. Increment (++) and Decrement (–)

Theory

* Increment means increasing a variable by 1.
* Decrement means decreasing a variable by 1.

Increment Examples

count++;
count += 1;
count = count + 1;

Decrement Examples

count--;
count -= 1;
count = count - 1;

Prefix and Postfix

Postfix: Uses the old value first, then changes it.

int x = 5;
int y = x++;

Result:

* y = 5
* x = 6

Prefix: Changes the value first, then uses it.

int x = 5;
int y = ++x;

Result:

* x = 6
* y = 6

⸻

3. The For Loop

Theory

A for loop is used when we know how many times a loop should repeat.

It has three main parts:

1. Initialization: Sets the starting value.
2. Test: Checks the condition.
3. Update: Increases or decreases the counter.

Syntax

for (initialization; condition; update)
{
    // Statements
}

Example

for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}

Explanation:

* int count = 0: Starting value.
* count < 5: Condition.
* count++: Increases the counter.
* The loop repeats 5 times.

Counting by 10

for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

Counting Backward

for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}

⸻

4. The Do-While Loop

Theory

A do-while loop executes the statements first and checks the condition afterward.

It is called a Posttest Loop.

The loop always executes at least once.

Syntax

do
{
    // Statements
}
while (condition);

Example

int number = 1;
do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);

Explanation:

Even though the condition is false, the message appears once because the condition is checked after execution.

⸻

5. Using Files for Data Storage

Theory

Files are used to save data for later use.

There are three main steps:

1. Open the file.
2. Process the file (Read or Write).
3. Close the file.

Types of Files

1. Text File

* Contains data encoded as text.
* Can be viewed using a text editor.

2. Binary File

* Contains data that has not been converted into text.
* Cannot normally be viewed as readable text in a text editor.

File Classes

C# provides two important classes:

* StreamWriter: Used to write data into a text file.
* StreamReader: Used to read data from a text file.

⸻

6. Writing Data to a File

Theory

StreamWriter is used to write information into a text file.

Example

using System.IO;
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");
outputFile.Close();

Important Functions

WriteLine()

* Writes data into a file.
* Moves to a new line.

Write()

* Writes data without moving to a new line.

CreateText() vs AppendText()

CreateText():

* Creates a new text file.
* If the file already exists, its previous contents are erased.

AppendText():

* Adds new information to an existing file.
* Keeps the previous contents.

Example:

StreamWriter outputFile;
outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");
outputFile.Close();



7. Reading Data from a File

Theory

StreamReader is used to read information from a text file.

Example

using System.IO;
StreamReader inputFile;
inputFile = File.OpenText("students.txt");
string line = inputFile.ReadLine();
MessageBox.Show(line);
inputFile.Close();

Types of Reading Methods

1. ReadLine()

* Reads one line.
* Returns a string.

2. Read()

* Reads the next character or characters.
* Returns an integer representing the character.

3. ReadToEnd()

* Reads all remaining content from the current position to the end of the file.

4. ReadAllText()

* Reads all text from a file.
* It is a method of the File class.

Reading a File Using a Loop

EndOfStream is a Boolean property that indicates whether the end of the file has been reached.

Example:

StreamReader inputFile;
inputFile = File.OpenText("students.txt");
while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
    MessageBox.Show(line);
}
inputFile.Close();



8. OpenFileDialog and SaveFileDialog

Theory

These controls allow users to open and save files using Windows dialog boxes.

OpenFileDialog

* Displays an Open dialog box.
* Allows the user to select a file.

SaveFileDialog

* Displays a Save As dialog box.
* Allows the user to select where to save a file.

These are invisible controls that appear in the Component Tray in the Designer.

OpenFileDialog Example

private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}

DialogResult

ShowDialog() returns a DialogResult value.

There are two important results:

* DialogResult.OK: The user clicks Open.
* DialogResult.Cancel: The user cancels.

Example:

DialogResult result = openFileDialog.ShowDialog();
if (result == DialogResult.OK)
{
    MessageBox.Show("File Selected");
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Cancelled");
}

Filename Property

Stores the path and filename of the selected file.

Example:

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamReader inputFile;
    inputFile = File.OpenText(openFileDialog.FileName);
}

InitialDirectory Property

Specifies the folder displayed when the dialog box opens.

Example:

openFileDialog.InitialDirectory = @"C:\Data";

SaveFileDialog Example

if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamWriter outputFile;
    outputFile = File.CreateText(saveFileDialog.FileName);
    outputFile.WriteLine("Hello C#");
    outputFile.Close();
}

⸻

9. Random Numbers

Theory

C# provides the Random class to generate random numbers.

Two commonly used methods are:

1. Next()

* Generates a random integer.

2. NextDouble()

* Generates a random floating-point number from 0.0 to 1.0.

Example

Random rand = new Random();
int number1 = rand.Next();
double number2 = rand.NextDouble();

Random.Next() Syntax

RandomObject.Next(max + 1);

Example:

Random rand = new Random();
int number = rand.Next(100);

This generates an integer from 0 to 99.


10. The Load Event

Theory

The Load Event happens when the application form is loaded into memory.

Any code written inside the Load Event executes when the form is launched.

Example

private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}

Explanation:

* Form1_Load: Load event handler.
* MessageBox.Show: Displays a message when the form starts.

To create a Load Event Handler, double-click the form in the Designer.

⸻

Important Summary

Topic	Purpose
while	Repeats while a condition is true
for	Repeats using a counter
do-while	Executes at least once
++	Increases by 1
–	Decreases by 1
StreamWriter	Writes data to a file
StreamReader	Reads data from a file
WriteLine()	Writes and moves to a new line
Write()	Writes without a new line
ReadLine()	Reads one line
Read()	Reads characters
ReadToEnd()	Reads remaining file content
CreateText()	Creates or overwrites a file
AppendText()	Adds data to an existing file
OpenFileDialog	Opens a file selection window
SaveFileDialog	Opens a save window
Random	Generates random numbers
Load Event	Executes when the form loads

Conclusion

Chapter 04 explains loops, increment and decrement operators, file handling, dialog controls, random numbers, and the Load Event.

These concepts help programmers develop C# applications that can repeat tasks, save and read information, and generate random values.