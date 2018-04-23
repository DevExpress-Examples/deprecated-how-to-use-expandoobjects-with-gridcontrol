Imports DevExpress.Xpf.Grid

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Threading
Imports DevExpress.Xpf.Core.ServerMode
Imports System.Data

Namespace dxSampleGrid
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            vm = New MyViewModel()
            DataContext = vm

        End Sub
        Private vm As MyViewModel
    End Class
End Namespace
