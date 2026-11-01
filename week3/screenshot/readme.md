
Screenshot 1: If Statement
The if statement checks a Boolean expression. A Boolean expression can
be either true or false.
General Syntax
if (expression)
{
    statement;
    statement;
}
If the condition is true, the statements inside the braces are
executed. If it is false, those statements are skipped.
Example
if (isColdOutside)
{
    MessageBox.Show("Wear a coat.");
}
The message appears only when isColdOutside is true.


Screenshot 2: Calculating the Average Test Score
This example reads three test scores, calculates their average, displays
the result, and shows a congratulatory message if the average is greater
than 95.
try
{
    const double HIGH_SCORE = 95.0;
    double test1, test2, test3, average;

    test1 = double.Parse(test1TextBox.Text);
    test2 = double.Parse(test2TextBox.Text);
    test3 = double.Parse(test3TextBox.Text);

    average = (test1 + test2 + test3) / 3.0;

    averageLabel.Text = average.ToString("n1");

    if (average > HIGH_SCORE)
    {
        MessageBox.Show("Congratulations! Great job!");
    }
}
catch (Exception ex)
{
    MessageBox.Show("Please enter valid numbers.");
}
- const declares a value that cannot be changed.
- double.Parse() converts TextBox input into a number.
- The average is calculated by adding the three scores and dividing by
  3.0.
- ToString("n1") displays the average to one decimal place.
- try contains code that might cause an error.
- catch handles an error, such as invalid input.


Screenshot 3: Removing Items from a ListBox
The Items.Remove() method removes an item by its value.
daysListBox.Items.Remove("Tuesday");
- daysListBox is the name of the ListBox control.
- Items refers to the items in the ListBox.
- Remove() removes the specified item.
- "Tuesday" is the item being removed.
Removing the Selected Item
if (listBox1.SelectedIndex != -1)
{
    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
}
else
{
    MessageBox.Show("Please select an item to remove.");
}
SelectedIndex != -1 checks whether an item is selected. RemoveAt()
removes the selected item. If no item is selected, a message is
displayed.



Screenshot 4: Boolean Values and If--Else
A bool variable stores one of two values: - true means the condition
is true. - false means the condition is not true.
Example
double points;
bool isGrandMaster;

points = double.Parse(txtPoints.Text);

if (points > 5000)
{
    isGrandMaster = true;
}
else
{
    isGrandMaster = false;
}

lblResult.Text = isGrandMaster.ToString();
If points is greater than 5000, isGrandMaster becomes true.
Otherwise, it becomes false.
- double.Parse() converts the TextBox text into a number.
- ToString() converts the Boolean value into text so it can be
  displayed in the Label.



Screenshot 5: Adding Items to a ListBox
The Items.Add() method adds a new item to a ListBox.
Example
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
Each line adds one day to the daysListBox.
Conclusion
These screenshots introduce important C# Windows Forms concepts:
decision-making with if and else, Boolean values, converting user
input, calculating averages, handling errors, and adding or removing
ListBox items.