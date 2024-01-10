using System.Text.RegularExpressions;

namespace absolute_layoutest;

public partial class absolute : ContentPage
{
	public absolute()
	{
		InitializeComponent();
	}

    private void entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		if (entry.Text != null)
		{
			title.IsVisible = true;
            vaild.IsVisible = true;
        }
        else { title.IsVisible = false;
            vaild.IsVisible = false;
        }
        string password = entry.Text;
        if (password.Length > 12 && Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success && Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success && Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success && Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
        {

            vaild.Text = "password is good";
            vaild.TextColor = Microsoft.Maui.Graphics.Color.Parse("green");
        }
        else
        {
            vaild.TextColor = Microsoft.Maui.Graphics.Color.Parse("red");
        }
            
            
    }
}