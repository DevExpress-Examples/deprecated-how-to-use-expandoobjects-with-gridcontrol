Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Dynamic
Imports DevExpress.Mvvm

Namespace dxSampleGrid

    Public Class GridViewModel
        Inherits ViewModelBase

        Public Sub New()
            PopulateItems()
        End Sub

        Public Property Items As ObservableCollection(Of ExpandoObject)
            Get
                Return GetValue(Of ObservableCollection(Of ExpandoObject))()
            End Get

            Set(ByVal value As ObservableCollection(Of ExpandoObject))
                SetValue(value)
            End Set
        End Property

        Private Sub PopulateItems()
            Items = New ObservableCollection(Of ExpandoObject)()
            For i As Integer = 0 To 10 - 1
                Dim dynObj As dynamic = New ExpandoObject()
                dynObj.ID = i
                dynObj.Name = $"Name{i}"
                Items.Add(dynObj)
            Next
        End Sub

        Private count As Integer

        Public Sub AddNew()
            For Each item In Items
                CType(item, IDictionary(Of String, Object))($"Column{count}") = "NewValue"
            Next

            count += 1
        End Sub
    End Class
End Namespace
