using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
namespace App2
{
    [Activity(Label = "VideoList", Icon = "@drawable/icon")]
    class VideoList : Activity
    {
        RecyclerView mRecyclerView;

        // Layout manager that lays out each card in the RecyclerView:
        RecyclerView.LayoutManager mLayoutManager;

        // Adapter that accesses the data set (a photo album):
        VideoAlbumAdapter mAdapter;

        // Photo album that is managed by the adapter:
        VideoAlbum mVideoAlbum;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.VideoLayoutPage);

            mVideoAlbum = new VideoAlbum();
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.VideoRecyclerView);
            var TakeVid = FindViewById<Button>(Resource.Id.NewVideoToBeTaken);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);
            mAdapter = new VideoAlbumAdapter(mVideoAlbum);
            mAdapter.ItemClick += OnItemClick;
            mRecyclerView.SetAdapter(mAdapter);

            TakeVid.Click += delegate
            {
                Intent k = new Intent(this, typeof(TakeVideo));
                this.StartActivity(k);
            };
        }
        void OnItemClick(object sender, int position)
        {
            // Display a toast that briefly shows the enumeration of the selected photo:
            int videoNum = position + 1;
            Toast.MakeText(this, "This is video number " + videoNum, ToastLength.Short).Show();
        }
        public class VideoViewHolder : RecyclerView.ViewHolder
        {
            public ImageView Image { get; private set; }
            public TextView Caption { get; private set; }

            // Get references to the views defined in the CardView layout.
            public VideoViewHolder(View itemView, Action<int> listener) : base(itemView)
            {
                // Locate and cache view references:
                Image = itemView.FindViewById<ImageView>(Resource.Id.videoView);
                Caption = itemView.FindViewById<TextView>(Resource.Id.textView);

                // Detect user clicks on the item view and report which item
                // was clicked (by position) to the listener:
                itemView.Click += (sender, e) => listener(base.Position);
            }
        }
        public class VideoAlbumAdapter : RecyclerView.Adapter
        {
            // Event handler for item clicks:
            public event EventHandler<int> ItemClick;

            // Underlying data set (a photo album):
            public VideoAlbum mVideoAlbum;

            // Load the adapter with the data set (photo album) at construction time:
            public VideoAlbumAdapter(VideoAlbum videoAlbum)
            {
                mVideoAlbum = videoAlbum;
            }

            // Create a new photo CardView (invoked by the layout manager): 
            public override RecyclerView.ViewHolder
                OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                // Inflate the CardView for the photo:
                View itemView = LayoutInflater.From(parent.Context).
                            Inflate(Resource.Layout.VideoCardView, parent, false);

                // Create a ViewHolder to find and hold these view references, and 
                // register OnClick with the view holder:
                VideoViewHolder vh = new VideoViewHolder(itemView, OnClick);
                return vh;
            }

            // Fill in the contents of the photo card (invoked by the layout manager):
            public override void
                OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                VideoViewHolder vh = holder as VideoViewHolder;

                // Set the ImageView and TextView in this ViewHolder's CardView 
                // from this position in the photo album:
                vh.Image.SetImageResource(mVideoAlbum[position].VideoID);
                vh.Caption.Text = mVideoAlbum[position].Caption;
            }

            // Return the number of photos available in the photo album:
            public override int ItemCount
            {
                get { return mVideoAlbum.NumVideos; }
            }

            // Raise an event when the item-click takes place:
            void OnClick(int position)
            {
                if (ItemClick != null)
                    ItemClick(this, position);
            }
        }
    }
}