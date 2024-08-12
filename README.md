# CSC205Homework
Questions:
1) Explain Method01 and insert necessary comments to the source code.
Method01 generates a file with random numbers within a specified range.

2) Explain Method02 and insert necessary comments to the source code.
Method02 sorts an array of integers using the selection sort algorithm.

3) What does the following code segmentaccomplish?
string[] lines = File.ReadAllLines(fileName);
int[] values = new int[lines.Length];
for (int i = 0; i < values.Length; i++)
{
    values[i] = Convert.ToInt32(lines[i]);
 }
The code segment reads all lines from the file “numbers.txt”, converts them to integers, and stores them in an array.

4) In what folder on your own computer is file "numbers.txt" located?
The file “numbers.txt” will be located in the same directory where the executable of your program is running. If you run the program from an IDE like Visual Studio, it will typically be in the project’s bin\Debug\net5.0 (or similar) folder. 
