using Android.App;
using Android.OS;

using Android.Widget;
using System;
using Android.Content;
using Android.Provider;
using Android.Graphics;
using Android.Runtime;
namespace App2
{
    [Activity(Label = "MakeNewProject", Icon = "@drawable/icon")]

    class MakeNewProject : Activity
    {
        
        public ImageView profilePc;
        private EditText NameofProject, PriceofHouse, numBedRooms, Address;
        private Button takePic, TakeVid;
        private ScrollView scroll;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.NewProjectPage);

            NameofProject = FindViewById<EditText>(Resource.Id.ProjectName);
            PriceofHouse = FindViewById<EditText>(Resource.Id.Price);
            numBedRooms = FindViewById<EditText>(Resource.Id.BedroomNumber);
            Address = FindViewById<EditText>(Resource.Id.address);
            takePic = FindViewById<Button>(Resource.Id.TakePic);
            TakeVid = FindViewById<Button>(Resource.Id.addProject);
            profilePc = FindViewById<ImageView>(Resource.Id.videoView);
            //
            scroll = FindViewById<ScrollView>(Resource.Id.scrollView);

            SetUpMap();
            takePic.Click += PicTaker;
            TakeVid.Click += VidTaker;
        }

        private void VidTaker(object sender, EventArgs e)
        {
            Intent takeVideo = new Intent(this, typeof(TakeVideo));
            this.StartActivity(takeVideo);
        }

        private void PicTaker(object sender, EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            StartActivityForResult(intent, 0);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Bitmap bitmap = (Bitmap)data.Extras.Get("data");
            profilePc.SetImageBitmap(bitmap);
        }

        private void SetUpMap()
        {
            /*cover
          / var frag = FragmentManager.FindFragmentById<TouchableMapFragment>(Resource.Id.map);
            if (frag != null)
            {
                frag.TouchUp += (sender, args) => scroll.RequestDisallowInterceptTouchEvent(false);
                frag.TouchDown += (sender, args) => scroll.RequestDisallowInterceptTouchEvent(true);

                mMap = frag.Map;
                if (mMap == null) return;
            }
            //this is the end */
          //  if (mMap == null)
            //{
              //  FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            //}
        }
        /*
        public void OnMapReady(GoogleMap googleMap)
        {

            MarkerOptions markerOptions = new MarkerOptions();
            markerOptions.SetPosition(new LatLng(53.264751, -8.929733));
            markerOptions.SetTitle("My Position");
            googleMap.AddMarker(markerOptions);
            mMap = googleMap;


        }
        */
    }
}