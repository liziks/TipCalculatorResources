namespace TipCalculatorResources.Views;

public partial class StandardTipPage : ContentPage
{
    public StandardTipPage()
    {
        InitializeComponent();

        billInput.TextChanged += OnBillTextChanged;
    }

    private void OnBillTextChanged(object sender, TextChangedEventArgs e)
    {
        if (double.TryParse(billInput.Text, out double bill))
        {
            double tip = bill * 0.15; 
            double total = bill + tip;

            tipOutput.Text = tip.ToString("F2");
            totalOutput.Text = total.ToString("F2");
        }
        else
        {
            tipOutput.Text = "0.00";
            totalOutput.Text = "0.00";
        }
    }
}