//screenshor/ Rules for Naming Controls

This slide explains how to give names to controls in a C# program.
Controls are identified by their names in the code.
Control names are also called identifiers.
The first character must be a letter or an underscore _.
Other characters can be letters, numbers, or underscores.
A name cannot contain spaces.
Examples:
showDayButton 
DisplayTotal 
_ScoreLabel 
3rdQuarterButton  because it starts with a number.
calculate Tax Button  because it contains spaces.

///screenshot 2: Adding Your Code

This slide explains how code works in a GUI application.
GUI programs are event-driven. This means the program waits for the user to do something.
For example:
Clicking a button
Pressing a key
Moving the mouse
An event handler is a method that runs when an event happens.
When we double-click a button in the Designer, Visual Studio creates a Click event handler automatically.
Example:
private void myButton_Click(object sender, EventArgs e)
{
}
We can put our own code inside the { }.

//screenshor 3:  Message Boxes

This slide explains MessageBox.
A message box is a small window that displays a message to the user.
In C#, we can use:
MessageBox.Show("Thanks for clicking the button!");
When the button is clicked, the message appears in a small window.
So, MessageBox.Show() is used to display information to the user.
Screenshot 4 Writing Code for the Hello World Application

This slide shows a simple Hello World Windows Forms application.
The program has a button. When the button is clicked, it displays:
MessageBox.Show("Hello World");
The important idea is that the code is inside the button's Click event handler.
So the program works like this:
Click button → Event happens → Code runs → "Hello World" appears.

Screenshot 5: Displaying Output in a Label crontal

This slide explains how to display information inside a Label control.
Example:
answerLabel.Text = "Jamhuriya University";
Here:
answerLabel is the name of the Label.
.Text is the property that controls the text.
= is the assignment operator.
"Jamhuriya University" is the text we want to display.
To clear the Label, we can use:
answerLabel.Text = "";


Screenshot 6 : Creating Clickable Images

This slide explains how to make a PictureBox respond when the user clicks it.
We can double-click the PictureBox in the Designer to create a Click event.
For example:
private void logicpicturebox_Click(object sender, EventArgs e)
{
    MessageBox.Show("welcome best class");
}
When the user clicks the picture, the message box appears.
Another example is:
studentpicturebox.Visible = false;
This makes the picture invisible when it is clicked.

Screenshot 7: Sequential Execution of Statements
This slide explains that C# statements normally execute from top to bottom.
For example:
cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;
First, the back picture becomes visible.
Second, the front picture becomes hidden.
The order of the statements is important. If we put the statements in the wrong order, the program may produce the wrong result.
This is called a logic error.

//Screenshot 8: Comments, Blank Lines, and Indentation
This slide explains comments in C#.
A comment is a note written in the code to explain what the code does.
A one-line comment starts with:
// Make image of the card back visible.
The computer does not execute the comment.
A block comment can contain several lines:
/*
Line one
Line two
*/
Comments help programmers understand their code.

//ScreenshotThis 9:slide explains blank lines and indentation.

Programmers use indentation to make code easier to read.
For example:
private void exitButton_Click(object sender, EventArgs e)
{
    // Close the form.
    this.Close();
}
The spaces before this.Close(); show that the statement belongs inside the method.
Blank lines can also separate different parts of the program.
Main idea: Good indentation and blank lines make code easier for people to read and understand.

///Sreenshot t11:Writing the Code to Close an Application’s Form
This slide explains how to close a Windows Form using C# code.
The main code is:
this.Close();
This statement closes the current form.
We can also create an Exit button and put the code inside its Click event:
private void exitButton_Click(object sender, EventArgs e)
{
    // Close the form.
    this.Close();
}
Another statement shown is:
Application.Exit();
This can be used to exit the application.


//Sreenshot  12 : Dealing with Syntax Errors
This slide explains syntax errors in C#.
Visual Studio checks the code while you are typing. If there is a syntax error, Visual Studio shows it with a jagged/zigzag line under the problem.
For example, if a statement is written incorrectly, Visual Studio marks the error.
If you try to run a program that contains syntax errors, Visual Studio will show a message saying that there are build errors.

