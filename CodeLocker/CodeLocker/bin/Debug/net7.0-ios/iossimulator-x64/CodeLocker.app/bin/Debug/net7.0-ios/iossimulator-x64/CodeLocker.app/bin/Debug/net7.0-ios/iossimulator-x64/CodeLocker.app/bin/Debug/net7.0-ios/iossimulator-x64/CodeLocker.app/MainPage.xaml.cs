namespace CodeLocker;

public partial class MainPage : ContentPage
{
    private string _correctPass = "1111";
    private string CorrectPass { get => _correctPass; set => _correctPass = value; }

    private string _currentPass;
    private string CurrentPass { get => _currentPass; set => _currentPass = value; }

    private int _currentPassLength = 0;
    private int CurrentPassLength { get => _currentPassLength; set => _currentPassLength = value; }

    private int _numOfTries = 0;
    private int NumOfTries { get => _numOfTries; set => _numOfTries = value; }

    private bool _isCorrectPassInput = false;
    private bool IsCorrectPassInput { get => _isCorrectPassInput; set => _isCorrectPassInput = value; }

    public MainPage()
    {
        InitializeComponent();
    }

    public void DigitClicked(object sender, EventArgs e)
    {
        if (CurrentPassLength < CorrectPass.Length && !IsCorrectPassInput)
        {
            CurrentPass += (sender as Button).Text;
            DisplayLabel.Text = CurrentPass;
            CurrentPassLength++;
        }
    }

    public void onClear(object sender, EventArgs e)
    {
        if (!IsCorrectPassInput)
        {
            DisplayLabel.Text = "";
            CurrentPassLength = 0;
            CurrentPass = "";
        }
    }

    public void PassChecker(object sender, EventArgs e)
    {
        if (CurrentPass == CorrectPass && !IsCorrectPassInput)
        {
            InfoLabel.Text = "Доступ открыт";
            IsCorrectPassInput = true;
        }
        else if (!IsCorrectPassInput)
        {
            NumOfTries++;
            InfoLabel.Text = $"Попробуйте еще раз. (Количество попыток: {NumOfTries})";
            onClear(sender, e);
        }
    }

    void CorrectPassEntry_HandlerChanging(System.Object sender, Microsoft.Maui.Controls.HandlerChangingEventArgs e)
    {
    }

    void CorrectPassEntry_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
    }

    void CorrectPassEntry_PropertyChanged_1(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
    }

    void CorrectPassEntry_PropertyChanged_2(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
    }

    void CorrectPassEntry_PropertyChanged_3(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
    }
}


