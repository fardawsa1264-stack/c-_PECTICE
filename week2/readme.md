ALL TOPIC DISCOUSS




3.1 Reading Input with TextBox Controls  
 3.2 A First Look at Variables  
 3.3 Numeric Data Type and Variables  
 3.4 Performing Calculations  
 3.5 Inputting and Outputting Numeric Values  
 3.6 Formatting Numbers with the ToString Method  
 3.7 Simple Exception Handling  
 3.8 Using Named Constants  
 3.9 Declaring Variables as Fields  
 3.10 Using the Math Class  
 3.11 More GUI Details  
 3.12 Using the Debugger to Locate Logic Errors


3.1 Reading Input with TextBox Controls
Explanation: This is the process of reading data typed by the user into a TextBox control on a Form when an
action is triggered (e.g., clicking a button). The data is captured as text (`string`).
string userName = textBox1.Text;
label1.Text = "Hello " + userName;
3.2 A First Look at Variables
Explanation: A variable is a temporary storage location in computer memory (RAM) used to hold specific
types of data while the program is running.
string firstName;
firstName = "Ahmed";
3.3 Numeric Data Type and Variables
Explanation: These are data types used to store numeric values, such as int for whole numbers and
double or decimal for numbers with fractional or decimal points.
int age = 25; // Whole number
double temperature = 36.6; // Number with decimal
3.4 Performing Calculations
Explanation: Using mathematical operators (such as +
, -
variables or numbers.
*
,
, /) to perform arithmetic calculations between
int num1 = 10;
int num2 = 5;
int sum = num1 + num2; // Result is 15
3.5 Inputting and Outputting Numeric Values
Explanation: Since text retrieved from a TextBox is always a `string`, you must convert (parse) it to a numeric
type (`int` or `double`) before doing math, and convert it back to `string` to display it.
int age = int.Parse(textBox1.Text);
label1.Text = age.ToString();
Page 1
3.6 Formatting Numbers with the ToString Method
Explanation: Formatting numbers using specifiers like `ToString("C")` to display currency formats or
controlling decimal places.
double price = 45.5;
label1.Text = price.ToString("c"); // Displays as currency e.g., $45.50
3.7 Simple Exception Handling
Explanation: A technique to prevent program crashes when a user inputs invalid data (e.g., typing letters
where numbers are expected) using `try-catch` blocks.
try {
int number = int.Parse(textBox1.Text);
} catch (FormatException) {
MessageBox.Show("Please enter a valid number!");
}
3.8 Using Named Constants
Explanation: A constant is a value that cannot be changed during program execution. It is declared using the
`const` keyword.
const double TaxRate = 0.05; // Tax rate remains constant
3.9 Declaring Variables as Fields
Explanation: A variable declared at the class level rather than inside a specific method or event handler,
making it accessible across multiple methods on the form.
public partial class Form1 : Form {
int totalScore = 0; // Accessible across form methods
}
3.10 Using the Math Class
Explanation: Utilizing C#'s built-in `Math` library which provides advanced mathematical operations such as
square roots (`Math.Sqrt`), rounding, etc.
double result = Math.Sqrt(25); // Returns 5
3.11 More GUI Details
Explanation: Learning advanced form design details, such as setting control tab orders (`TabIndex`) to
manage how focus shifts when using the keyboard.
Page 2
// Setting TabIndex property in properties window or code
textBox1.TabIndex = 0;
3.12 Using the Debugger to Locate Logic Errors
Explanation: Using Visual Studio's built-in debugging tools (such as Breakpoints) to step through code line-