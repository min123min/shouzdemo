using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace App2
{
    [Activity(Label = "showHouse3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private EditText InputUserName, InputPassword;
        private Android.Widget.Button BtnCheck;


        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            InputUserName = FindViewById<EditText>(Resource.Id.UserName);
            InputPassword = FindViewById<EditText>(Resource.Id.Password);
            BtnCheck = FindViewById<Android.Widget.Button>(Resource.Id.LoginButton);

            BtnCheck.Click += LoginButtonClicked;
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {

            var user = new User
            {
                Username = InputUserName.Text,
                Password = InputPassword.Text
            };
            string use = user.Username;
            string pass = user.Password;
            //  url =new Uri ("http://localhost:64244/api/Login/Authentication" +"/"+ use+"/" + pass);
            //Uri My = url;
            //mClient.DownloadDataAsync(My);
            //mClient.DownloadDataCompleted += mClient_DownloadDataCompleted;
            //  var isValid = AreCredentialsCorrect(user);
            //  JsonValue check = await Getifcorrect(url);
            var isValid = AreCredentialsCorrect(user);
            if ((bool)isValid)
            {
                try
                {

                    Intent k = new Intent(this, typeof(MainPage));
                    // Intent.PutExtra("userName", user.Username);
                    this.StartActivity(k);
                }
                catch (Java.Lang.Exception error)
                {

                }



                // await Navigation.PopAsync(new MainPage());
                //  App.IsUserLoggedIn = true;

            }
            else
            {

            }

        }
        /*
        private void mClient_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
             list = new List<string>();
            RunOnUiThread(() => {
                string json = Encoding.UTF8.GetString(e.Result);
                string holder = Newtonsoft.Json.JsonConvert.DeserializeObject <list> (json);
              //  string check = (bool)holder;
                if (holder == "true")
                {

                }
            });
          
        }

  */

        /*
private async Task Getifcorrect(string url)
{
   using (WebResponse response = await request.GetResponseStream())
   {
       using (Stream stream = response.GetResponseStream())
       {

       }
   }
}
*/
        private object AreCredentialsCorrect(User user)
        {
            return user.Username == CheckingLogin.Username && user.Password == CheckingLogin.Password;
        }
    }
}

