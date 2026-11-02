
Screen 1 – Reading a File with StreamReader

This example shows how to open and read a file using `StreamReader`.

- `OpenFileDialog` allows the user to select a file.
- `File.OpenText()` opens the selected file.
- `ReadLine()` reads the file one line at a time.
- `ListBox` displays each line.
- `reader.Close()` closes the file after reading.

The `while` loop continues reading until the end of the file is reached.

---

## Screen 2 – Dialog Result: OK or Cancel

This example checks whether the user selects **OK** or **Cancel** in the file dialog.

- `ShowDialog()` displays the file selection dialog.
- `DialogResult.OK` means the user selected a file.
- `DialogResult.Cancel` means the user cancelled the operation.
- If the user selects OK, the program reads the file.
- If the user selects Cancel, a message box displays a cancellation message.

This prevents the program from trying to read a file when the user cancels the dialog.

---

## Screen 3 – ReadLine Method

This example demonstrates the `ReadLine()` method.

- `File.OpenText()` opens the file.
- `StreamReader` is used to read the file.
- `ReadLine()` reads one line at a time.
- The `while` loop reads all lines until the end of the file.
- Each line is added to the `ListBox`.
- `try-catch` handles errors that may occur while opening or reading the file.

If an error occurs, `MessageBox.Show()` displays the error message.

---

## Screen 4 – Reading a File

This screen shows different ways to read data from a file.

### ReadLine()
`ReadLine()` reads one complete line from the file.

### Read()
`Read()` reads one character at a time.

### ReadToEnd()
`ReadToEnd()` reads all remaining content from the file.

### File.ReadAllText()
`ReadAllText()` reads the complete text of a file and stores it in a string.

After reading the file, `Close()` is used to close the `StreamReader`.

---

## Screen 5 – Prefix and Postfix Operators

This example demonstrates the difference between **postfix** and **prefix** increment operators.

### Postfix: `count++`

The current value is used first, and then `count` is increased.

For example:

```csharp
int count = 5;
int x = 0;

x = count++;
```

After this statement:

- `x = 5`
- `count = 6`

### Prefix: `++count`

The value is increased first, and then the new value is used.

For example:

```csharp
int count = 5;
int x = 0;

x = ++count;
```

After this statement:

- `count = 6`
- `x = 6`

### Main Difference

- **Postfix (`count++`)** → use the value first, then increase it.
- **Prefix (`++count`)** → increase the value first, then use it.