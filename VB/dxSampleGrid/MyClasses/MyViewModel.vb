Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Dynamic
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Input

Namespace dxSampleGrid
    Public Class MyViewModel
        Public Sub New()
            CreateList()
            GenerateColumns()
        End Sub

        Public Property PersonList() As ObservableCollection(Of ExpandoObject)
        Public Property MyColumns() As ObservableCollection(Of MyColumn)

        Private Sub CreateList()
            PersonList = New ObservableCollection(Of ExpandoObject)()
            For i As Integer = 0 To 9
                Dim p As New Person(i)
                Dim persDictionary As New ExpandoObject()
                Dim dict As IDictionary(Of String, Object) = DirectCast(persDictionary, IDictionary(Of String, Object))
                 dict("dFirstName") = p.FirstName
                 dict("dLastName") = p.LastName
                 dict("dAge") = p.Age
                 PersonList.Add(persDictionary)
            Next i
        End Sub

        Public Sub GenerateColumns()
            MyColumns = New ObservableCollection(Of MyColumn)()
            MyColumns.Add(New MyColumn() With {.FieldName = "dFirstName"})
            MyColumns.Add(New MyColumn() With {.FieldName = "dLastName"})
            MyColumns.Add(New MyColumn() With {.FieldName = "dAge"})
        End Sub

    End Class
End Namespace
