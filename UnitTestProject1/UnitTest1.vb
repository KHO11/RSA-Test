Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports weba

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        String expectedOutput = fileOperator.ReadStringFromFile("File.csv");
        String result = systemUnderTest.Parse(somethingtoparse);
        Assert.Equals(expectedOutput, result);
        Console.WriteLine("CSV file uploaded")

    End Sub

End Class