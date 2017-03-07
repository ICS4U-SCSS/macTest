using System;
using System.Collections.Generic;
using AudioManager;

using Xamarin.Forms;

namespace MagicBall
{
	public partial class HomePage : ContentPage
	{
		#region sayings array setup
		string[] options = {" It is certain"
			, " Hey there handsome"
			, " Without a doubt"
			, " Yes definitely"
			, " You may rely on it"
			, " As I see it, yes"
			, " Most likely"
			, " Outlook good"
			, " Yes"
			, " Signs point to yes"
			, " Reply hazy try again"
			, " Ask again later"
			, " Better not tell you now"
			, " Cannot predict now"
			, " Concentrate and ask again"
			, " Don't count on it"
			, " My reply is no"
			, " My sources say no"
			, " Outlook not so good"
			, " Very doubtful "
  		};
		#endregion

		string nameActual = "Bob";
		String passwordActual = "1234";

		public HomePage()
		{
			InitializeComponent();
			this.BackgroundColor = Color.White;
		}

		public void shakeButton_Clicked(object sender, EventArgs args)
		{
			//outputLabel.Text = options[new Random().Next(options.Length - 1)];

			//DependencyService.Get<IAudio>().PlayAudioFile("beep.mp3");
			var page = new MagicBallPage();
			App.Current.MainPage = page;

		}



		void loginButton_Clicked(object sender, EventArgs args)
		{
			String username = nameInput.Text;
			String password = passwordInput.Text;

			if (username == nameActual && password == passwordActual)
			{
				welcomeLabel.Text = "Welcome " + username;
				this.BackgroundColor = Color.White;
			}
			else
			{
				welcomeLabel.Text = "Wrong username or password";
				this.BackgroundColor = Color.Red;
			}
		}
	}
}
