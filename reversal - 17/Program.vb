'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 18/11/2021
' Time: 13:49
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Dimesions and array
		Dim num(5) As Int64
		
		'Inputs data from the user into the array
		For c=0 To 4
			Console.WriteLine("Please enter a number . . . ")
			num(c) = Console.ReadLine()
		Next
		
		'Reads from the array in reverse order
		For c=4 To 0 Step - 1
			Console.WriteLine(num(c))
		Next
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
