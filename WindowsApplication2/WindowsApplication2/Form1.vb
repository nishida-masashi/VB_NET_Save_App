Public Class Form1

    Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        TrackBar1.DataBindings.Add(New Binding("Minimum", Me, "NMin", True, DataSourceUpdateMode.OnPropertyChanged))
        TrackBar1.DataBindings.Add(New Binding("Maximum", Me, "NMax", True, DataSourceUpdateMode.OnPropertyChanged))
        TrackBar1.DataBindings.Add(New Binding("Value", Me, "NV", True, DataSourceUpdateMode.OnPropertyChanged))

        NumericUpDown1.DataBindings.Add(New Binding("Value", Me, "TV", True, DataSourceUpdateMode.OnPropertyChanged))

    End Sub

    ReadOnly Property P As Double
        Get
            Return Math.Pow(10, NumericUpDown1.DecimalPlaces)
        End Get
    End Property

    Property NMin As Decimal
        Get
            Return NumericUpDown1.Minimum * P
        End Get
        Set(value As Decimal)
            NumericUpDown1.Minimum = value / P
        End Set
    End Property

    Property NMax As Decimal
        Get
            Return NumericUpDown1.Maximum * P
        End Get
        Set(value As Decimal)
            NumericUpDown1.Maximum = value / P
        End Set
    End Property

    Property NV As Decimal
        Get
            Return NumericUpDown1.Value * P
        End Get
        Set(value As Decimal)
            NumericUpDown1.Value = value / P
        End Set
    End Property

    Property TV As Decimal
        Get
            Dim d As Decimal = TrackBar1.Value
            Return d / P
        End Get
        Set(value As Decimal)
            TrackBar1.Value = value * P
        End Set
    End Property

    
End Class
