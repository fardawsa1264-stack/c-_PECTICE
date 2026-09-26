all TOPIC DISCUSS
Topic Simple meaning
Objects Things created from a class
Program Development Steps for creating a program
Visual Studio Program used to write C#
Forms & Controls Window and items inside it
GUI What the user sees and uses
C# Code Instructions for the computer
Hello World Simple first program
Label Displays text
IntelliSense Gives code suggestions
PictureBox Displays pictures
Comments Explain code
Close Form Closes the current window
Syntax Error Incorrect C# code
Quick Revision



//1.1 Objects
Simple English: An object is a thing in a program that has data and actions.
Somali: Object waa wax program-ka ku jira oo leh xog (data) iyo shaqo (action).
Example:
Student student1 = new Student();
Explanation: Student = class, student1 = object, and new Student() creates the object.

//1.2 The Program Development Process

Simple English: The program development process is the steps we use to create a program.
Somali: Waa tallaabooyinka lagu sameeyo program.
Example:
Problem → Plan → Code → Test → Fix errors
Explanation: First understand the problem, then plan, write code, test it, and fix errors.

//1.8 Getting Started with Visual Studio
Simple English: Visual Studio is a program used to create applications.
Somali: Visual Studio waa IDE lagu qoro, lagu ordo, laguna tijaabiyo C# programs.
Example:
MessageBox.Show("Hello");
Explanation: This code displays a message box with Hello.

//2.1 Getting Started with Forms and Controls
Simple English: A Form is the window of an application. A Control is an item placed on the form.
Somali: Form waa daaqadda app-ka. Control waa wax lagu dhex daro form-ka.
Example:
Form: window
Controls: Button, Label, TextBox, PictureBox
Explanation: A form can contain many controls.

//2.2 Creating the GUI for Your First Visual C# Application
Simple English: GUI means Graphical User Interface. It is what the user sees and uses.
Somali: GUI waa muuqaalka uu user-ku arko oo uu isticmaalo.
Example:
private void button1_Click(object sender, EventArgs e)\n{\n MessageBox.Show("Welcome");\n}
Explanation: When the user clicks the button, it shows Welcome.

////2.3 Introduction to C# Code
Simple English: C# is a programming language used to create applications.
Somali: C# waa luqad programming ah oo lagu sameeyo applications.
Example:
string name = "Ali";\nMessageBox.Show(name);
Explanation: string is the data type, name is the variable, and Ali is the value.
////2.4 Writing Code for the Hello World Application
Simple English: Hello World is a simple program used to learn programming.
Somali: Hello World waa program fudud oo beginners lagu baro programming.
Example:
MessageBox.Show("Hello World");
Explanation: The program displays Hello World.


//2.5 Label Controls
Simple English: A Label is a control that displays text on a form.
Somali: Label waxaa loo isticmaalaa in qoraal lagu muujiyo form-ka.
Example:
label1.Text = "Welcome";
Explanation: The label will show Welcome.
2.6 Making Sense of IntelliSense
Simple English: IntelliSense is a Visual Studio feature that helps you write code.
Somali: IntelliSense wuxuu ku siinayaa suggestions sida methods iyo properties.
Example:
label1.Text = "Hello";
Explanation: When you type label1., Visual Studio can show Text, Name, Width, Height, and
other suggestions.

///2.7 PictureBox Controls
Simple English: A PictureBox is a control used to display an image.
Somali: PictureBox waxaa loo isticmaalaa in sawir lagu soo bandhigo.
Example:
pictureBox1.Image = Image.FromFile("cat.jpg");
Explanation: This loads the cat.jpg image.


///2.8 Comments, Blank Lines, and Indentation
Simple English: Comments explain code. Blank lines make code easier to read. Indentation
makes code clear.
Somali: Comments waa faallooyin; blank lines iyo indentation waxay hagaajiyaan akhriska
code-ka.
Example:
// This displays a message\nMessageBox.Show("Hello");
Explanation: The computer does not run a // comment.


///2.9 Writing the Code to Close an Application’s Form
Simple English: We can write code to close the current form.
Somali: Waxaan qori karnaa code xiraya form-ka hadda furan.
Example:
private void button1_Click(object sender, EventArgs e)\n{\n this.Close();\n}
Explanation: When the user clicks the button, the current form closes.


///2.10 Dealing with Syntax Errors
Simple English: A syntax error happens when code is written incorrectly.
Somali: Syntax error wuxuu dhacaa marka xeerarka C# si khaldan loo qoro.
Example:
Wrong: MessageBox.Show("Hello"\nCorrect: MessageBox.Show("Hello");
Explanation: The correct code needs the closing );
