namespace Potato;

public partial class FruitDetailed : ContentPage
{
    public FruitDetailed(string name, string image, string description)
    {
        InitializeComponent();

        // 在 UI 元素中設置數據
        fruitName.Text = name;
        fruitImg.Source = image;
        fruitDescription.Text = description;
    }

}