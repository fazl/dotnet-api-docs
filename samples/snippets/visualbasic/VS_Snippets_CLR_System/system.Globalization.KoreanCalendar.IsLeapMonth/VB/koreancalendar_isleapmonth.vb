﻿' The following code example calls IsLeapMonth for all the months in five years in the current era.

' <snippet1>
Imports System.Globalization

Public Class SamplesKoreanCalendar   
   
   Public Shared Sub Main()

      ' Creates and initializes a KoreanCalendar.
      Dim myCal As New KoreanCalendar()

      ' Checks all the months in five years in the current era.
      Dim iMonthsInYear As Integer
      Dim y As Integer
      For y = 4334 To 4338
         Console.Write("{0}:" + ControlChars.Tab, y)
         iMonthsInYear = myCal.GetMonthsInYear(y, KoreanCalendar.CurrentEra)
         Dim m As Integer
         For m = 1 To iMonthsInYear
            Console.Write(ControlChars.Tab + "{0}", myCal.IsLeapMonth(y, m, KoreanCalendar.CurrentEra))
         Next m
         Console.WriteLine()
      Next y

   End Sub

End Class


'This code produces the following output.







' </snippet1>