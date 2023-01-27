# SignalCharting
A C# WindowsForm Application to show EEG medical test results on charts.

This program can read the data from a .txt file or from MySql database.

- Browse .txt File
	By pressing this button a Windows Explorer window would open to choose and load a text file(*.txt).
	It loads all the data required for the program to display EEG signals on the charts.

- Sample Rate (Hz)
	The number of samples per second. Its default value is 500, but it could be modified. After modifying
	the value and pressing the small button besides it, the change will be applied in the program.

- Channel1-5
	This program can display up-to 5 channels and the selected channel could be changed by changing the 
	selected index of the corresponding combobox.

- Choose Pateint
	By pressing this button a table will show up on the upper right side of the main window, containing
	a list of pateints stored in MySql database called 'patients' in the table 'information'. Double clicking
	on the second column of each row will lead to displaying the row's data in the textboxes.

- Enable Editing
	By checking it the 'Save Edit' button will be activated and the textboxes become editable. After changing the
	value of textboxes and pushing 'Save Edit' button, the new information will be saved in the database and the
	patients table on the upper right side of the main window will show the updated data of the row.