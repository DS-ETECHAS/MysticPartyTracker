using MysticPartyTracker.Models;
namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
    public DiceView()
    {
        InitializeComponent();
        SidesPicker.SelectedIndex = 0;
        QuantityPicker.SelectedIndex = 0;
    }

    private void RollBtn_Clicked(object sender, EventArgs e)
    {
        int numberSides = (int)SidesPicker.SelectedItem;
        int quantity = (int)QuantityPicker.SelectedItem;

        Dice dice = new(numberSides);

        string finalResult = "";
        int total = 0;

        for (int i = 0; i < quantity; i++)
        {
            int roll = dice.Roll();
            Console.WriteLine(roll);
            finalResult += $"Dado {i + 1} = {roll}\n";
            total += roll;
        }

        finalResult += $"Total = {total}";


        AllDicesResultLabel.Text = $"Foram jogados {quantity} dado(s) de {numberSides} lados.";
        ResultString.Text = $"Resultado:\n\n{finalResult}\n";
        RandomNumber.Text = $"Total: {total}";

    }

}
