Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    <TestMethod()> Public Sub TestMethod1()
        Dim F1 As New Functions.Form1
       Assert.IsTrue(F1.area(4, 5)=20)
    End Sub

End Class