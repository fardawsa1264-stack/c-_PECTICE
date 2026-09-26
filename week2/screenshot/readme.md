//Sreenshor 1: Breakpoints (2 of 2)
(Explanation):
A breakpoint is a tool in Visual Studio that pauses (stops) your program at a specific line of code. It helps you check variables and fix errors (bugs) step by step. You add it by clicking the margin next to the line number.  
 (Example):
If you click line 18 in calculateButton_Click, the code stops before reading runner1TextBox.Text. This lets you test if the input is correct.  

//Sreenshor 2: The FieldDemo Application
 (Explanation):
A field is a variable created directly inside a class, outside any method. Because it is a field, every method inside that class can access and change its value.  
 (Example):
The variable private string name = "Charles"; is a field. The buttons showNameButton, dariusButton, and carmenButton can all read or change the name variable.  
//Sreenshor 3: Solution The Code
 (Explanation):
This code uses a try-catch block to calculate the average of three test scores safely. If the user enters invalid data (like text instead of a number), the catch block catches the error and shows a message instead of crashing.  
 (Example):
If the user enters "90", "80", and "70", it calculates the average 80.0. If they type "abc", catch (Exception ex) catches it and displays ex.Message.

//Sreenshor 4: Throwing an Exception
Explanation):
When an error happens inside a try block, C# throws an exception. The program stops the remaining code in try and immediately jumps to the catch block.  
(Example):
If milesTextBox.Text contains letters, double.Parse(...) fails. The code skips calculating MPG and directly goes to catch, showing "Invalid data was entered."


//Sreenshor 5: Example (CultureInfo & Formatting
Explanation):
Different countries format numbers differently (for example, using commas , or dots . for decimals). CultureInfo allows you to format numbers according to a specific country's rules.  
 (Example):
number.ToString("N", CultureInfo.GetCultureInfo("de-DE")) formats numbers for Germany (using , for decimals), while "en-US" formats for the US (using .)
.  
//Sreenshor 6: 3.5 Inputting and Outputting Numeric Values
 (Explanation):
Text entered into a TextBox is always treated as a string, even if it looks like a number. You cannot directly assign it to a number variable; you must use Parse methods.  
 (Example):
​int.Parse("25") converts string "25" to integer 25.  
​double.Parse(temperatureTextBox.Text) converts text to a decimal number.

//Sreenshor 7: Declaring Local Variables with the var Keyword
d (Explanation):
The var keyword lets the C# compiler guess (infer) the variable's data type automatically based on the assigned value. It can only be used for local variables inside methods and must have an initial value.  
 (Example):
​var interestRate = 12.0; \rightarrow compiler sets it as double.  
​var stockCode = "D465U"; \rightarrow compiler sets it as string.

//Sreenshor 8: Assignment Compatibility for decimal Variables
(IExplanation):
A decimal variable can hold decimal numbers (ending with m) and int numbers, but cannot hold double numbers without conversion.  
(Example):
​decimal balance = 9280.73m; (Works)  
​decimal price = 50; (Works)  
​decimal sales = 6500.0; (ERROR because 6500.0 is a double) 


//Sreenshor 9: Assignment Compatibility for int and double Variables
 (Explanation):
​int: Only stores whole numbers (int). It cannot store double or decimal.  
​double: Stores decimal numbers (double) and whole numbers (int), but cannot store decimal (m).  
 (Example):
​int hoursWorked = 40; (Works)  
​int score = -25.5; (ERROR)  
​double distance = 28.75; (Works)  
​double sales = 6500.0m; (ERROR)
  
//Sreenshor 10: Local Variables and Scope
 (Explanation):
A local variable is declared inside a specific method. Its scope (visibility) is limited to that method only. Other methods cannot see or use it, and it is destroyed when the method ends.  
 (Example):
myName is created inside firstButton_Click. If secondButton_Click tries to use outputLabel.Text = myName;, C# gives an ERROR because myName does not exist there.

Screenshot 11: Declaring Variables Before Using Them
 (Explanation):
You can create (declare) a variable first and give it a value later in your code. First, you define its data type and name, then you assign text or numbers to it when needed.  
Example:
​string fullname; creates the variable.  
​fullname = firstNameTextBox.Text + " " + lastNameTextBox.Text; joins the first and last names together and saves them into fullname.  
​fullNameLabel.Text = fullname; displays the full name in a label on the form.

Screenshot 12 : String Concatenation
 (Explanation):
Concatenation means joining two or more strings together into one long string using the + operator. You can also combine text with other data types like numbers (int or double), and C# automatically converts those numbers into text.  
e (Example):
​"Jamhuuriya" + "University" becomes "JamhuuriyaUniversity".  
​2025 + "Jamhuuriya Class" joins the number 2025 with text to give "2025Jamhuuriya Class".  
​"Total is " + 25.75 gives "Total is 25.75".

Screenshot 13: String Variables
(Explanation):
A string variable holds text, such as names, phone numbers, or addresses. When you assign text to a string variable, you must always surround the text with double quotation marks ("..."). You can assign string variables to controls like labels or show them in message boxes.  
Example:
​productDescription = "Jamhuuriya University"; saves the university name inside productDescription.  
​productLabel.Text = productDescription; displays that text inside a screen label.  
​MessageBox.Show(productDescription); pops up a popup window showing "Jamhuuriya University". 

Screenshot 14:The Text Property
Explanation:
The Text property of a TextBox stores whatever text the user types into it. Since it only holds string values, you must set or clear it using strings. There are three common ways to erase or clear the text inside a TextBox.  
 Example:
​textBox1.Text = "Hello"; puts the word "Hello" into the text box.  
​To clear textBox1, you can use any of these methods:
​textBox1.Text = ""; (assigns empty quotation marks)  
​textBox1.Text = string.Empty; (uses the built-in empty string value)  
​textBox1.Clear(); (calls the clear function directly)