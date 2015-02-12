Public Class Form2

    Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        TrackBar1.DataBindings.Add(New Binding("Value", Me, "NV", True, DataSourceUpdateMode.OnPropertyChanged))
        NumericUpDown1.DataBindings.Add(New Binding("Value", Me, "TV", True, DataSourceUpdateMode.OnPropertyChanged))

    End Sub

    Property NV As Decimal
        Get
            Return 10 - NumericUpDown1.Value
        End Get
        Set(value As Decimal)
            NumericUpDown1.Value = 10 - value
        End Set
    End Property

    Property TV As Decimal
        Get
            Return 10 + TrackBar1.Value
        End Get
        Set(value As Decimal)
            TrackBar1.Value = 10 - value
        End Set
    End Property


End Class
