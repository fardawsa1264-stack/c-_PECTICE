CHAPTER 3: MAKING DECISIONS

1. Decision Structures and if Statement



A decision structure executes statements only under certain circumstances.

It uses a condition that can be true or false.

Explanation:
if checks a condition. If the condition is true, the code executes.

Code:

int age = 20;
if (age >= 18)
{
    MessageBox.Show("Adult");
}

Function: Checks whether a condition is true.


2. The if-else Statement



An if-else statement executes one block if the condition is true and another block if it is false.

Code:

int age = 16;
if (age >= 18)
{
    MessageBox.Show("Adult");
}
else
{
    MessageBox.Show("Not Adult");
}

Function: Gives two possible outcomes.



3. Nested Decision Structures



Nested means one decision structure inside another decision structure.

It is used to check more than one condition.

Code:

int age = 20;
if (age >= 18)
{
    if (age >= 20)
    {
        MessageBox.Show("Accepted");
    }
}

Function: Checks multiple conditions.


4. Logical Operators

Theory:

Logical operators connect two or more Boolean expressions.

There are three main logical operators:

Operator	Meaning
&&	AND
	
!	NOT

Code:

int age = 20;
if (age >= 18 && age <= 60)
{
    MessageBox.Show("Valid age");
}

Explanation:

* AND (&&): Both conditions must be true.
* OR (||): One or both conditions must be true.
* NOT (!): Reverses the condition.

⸻

5. bool Variables and Flags


A bool variable stores only two values: true or false.

A flag is a variable that signals when a condition exists.

Code:

bool isPassed = true;
if (isPassed)
{
    MessageBox.Show("Passed");
}
else
{
    MessageBox.Show("Failed");
}

Function: Stores and checks true or false values.

⸻

6. Comparing Strings

Theory:

String comparison is used to compare two text values.

We can use ==, != and String.Compare().

Code:

string name1 = "Ahmed";
string name2 = "Ahmed";
if (name1 == name2)
{
    MessageBox.Show("Names are equal");
}
else
{
    MessageBox.Show("Names are different");
}

Function: Compares two strings.



7. TryParse Method



TryParse converts a string into a numeric value and checks whether the conversion is successful.

Types of TryParse:

1. int.TryParse()
2. double.TryParse()
3. decimal.TryParse()

Code:

int age;
if (int.TryParse(textBox1.Text, out age))
{
    MessageBox.Show("Valid number");
}
else
{
    MessageBox.Show("Invalid input");
}

Function: Prevents data conversion exceptions.


8. Input Validation



Input validation checks whether entered data is valid before it is used.

Code:

int age;
if (int.TryParse(textBox1.Text, out age))
{
    if (age >= 1 && age <= 100)
    {
        MessageBox.Show("Valid age");
    }
    else
    {
        MessageBox.Show("Invalid age");
    }
}
else
{
    MessageBox.Show("Enter a number");
}

Function: Checks whether user input is valid and within an acceptable range.



9. Radio Buttons and Check Boxes

A. RadioButton


RadioButton allows users to select only one choice from several options.

Code:

if (radioButton1.Checked)
{
    MessageBox.Show("Male selected");
}
else if (radioButton2.Checked)
{
    MessageBox.Show("Female selected");
}

Function: Selects one option.

B. CheckBox



CheckBox allows users to select multiple options.

Code:

if (checkBox1.Checked)
{
    MessageBox.Show("Option selected");
}

Function: Allows multiple selections.


10. Switch Statement


The switch statement selects one option from several possible choices.

It is an alternative to an if-else-if statement.

Code:

int day = 1;
switch (day)
{
    case 1:
        MessageBox.Show("Monday");
        break;
    case 2:
        MessageBox.Show("Tuesday");
        break;
    default:
        MessageBox.Show("Invalid day");
        break;
}

Function: Selects an action based on a value.


11. Introduction to ListBox


A ListBox displays a list of items and allows users to select an item.

Important ListBox Properties and Methods

Property/Method	Function
Items.Add()	Adds an item
Items.Remove()	Removes a specific item
Items.RemoveAt()	Removes an item using index
Items.Clear()	Removes all items
Items.Count	Counts items
SelectedItem	Gets the selected item
SelectedIndex	Gets the selected index
Text	Gets the selected text

A. Add Items

Code:

listBox1.Items.Add("Apple");
listBox1.Items.Add("Mango");
listBox1.Items.Add("Orange");

Function: Adds items to the ListBox.

B. Remove Items

Code:

listBox1.Items.Remove("Apple");

Function: Removes a specific item.

C. RemoveAt

Code:

listBox1.Items.RemoveAt(0);

Function: Removes an item using its index.

D. Clear

Code:

listBox1.Items.Clear();

Function: Removes all items.

E. Items.Count

Code:

int total = listBox1.Items.Count;
MessageBox.Show(total.ToString());

Function: Counts the total number of items.

F. SelectedItem

Code:

if (listBox1.SelectedIndex != -1)
{
    string item = listBox1.SelectedItem.ToString();
    MessageBox.Show(item);
}

Function: Gets the selected item.

G. SelectedIndex

Code:

int index = listBox1.SelectedIndex;

Function: Gets the index of the selected item.



