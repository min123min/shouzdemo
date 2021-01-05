using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace App2

{
    [Activity(Label = "MainPage", Icon = "@drawable/icon")]

    class MainPage : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainMenuPage);

            var TakeVid = FindViewById<Button>(Resource.Id.MakeNewProject);
            var FileSystem1 = FindViewById<Button>(Resource.Id.FileSystem);
            TakeVid.Click += MakeNewPro;



            FileSystem1.Click += delegate
            {

                Intent F = new Intent(this, typeof(ProjectList));
                this.StartActivity(F);
                /*
              var mainPage = this.BaseContext as MainPage;
              Intent intent = new Intent(); // Create your external app intent here.
              mainPage.StartActivity(intent, ProjectList);
              */
            };

        }

        private void MakeNewPro(object sender, EventArgs e)
        {
            try
            {
                Intent T = new Intent(this, typeof(MakeNewProject));
                this.StartActivity(T);
            }
            catch
            {

            }
        }
    }

}