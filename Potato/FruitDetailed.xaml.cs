namespace Potato;

public partial class FruitDetailed : ContentPage
{
    public FruitDetailed(string name, string image, string description)
    {
        InitializeComponent();

        // �b UI �������]�m�ƾ�
        fruitName.Text = name;
        fruitImg.Source = image;
        fruitDescription.Text = description;
    }

}