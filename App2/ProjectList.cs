using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace App2
{
    [Activity(Label = "ProjectList", Icon = "@drawable/icon")]
    class ProjectList : Activity
    {

        // RecyclerView instance that displays the photo album:
        RecyclerView mRecyclerView;

        // Layout manager that lays out each card in the RecyclerView:
        RecyclerView.LayoutManager mLayoutManager;

        // Adapter that accesses the data set (a photo album):
        ProjectAlbumAdapter mAdapter;

        // Photo album that is managed by the adapter:
        ProjectAlbum mProjectAlbum;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FolderLayoutPage);

            mProjectAlbum = new ProjectAlbum();
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);
            mAdapter = new ProjectAlbumAdapter(mProjectAlbum);
            mAdapter.ItemClick += OnItemClick;
            mRecyclerView.SetAdapter(mAdapter);
        }
        void OnItemClick(object sender, int position)
        {
            // Display a toast that briefly shows the enumeration of the selected photo:
            int projectNum = position + 1;
            Toast.MakeText(this, "This is video number " + projectNum, ToastLength.Short).Show();
            Intent F = new Intent(this, typeof(VideoList));
            this.StartActivity(F);

        }
        public class ProjectViewHolder : RecyclerView.ViewHolder
        {
            public ImageView Image { get; private set; }
            public TextView Caption { get; private set; }

            // Get references to the views defined in the CardView layout.
            public ProjectViewHolder(View itemView, Action<int> listener) : base(itemView)
            {
                // Locate and cache view references:
                Image = itemView.FindViewById<ImageView>(Resource.Id.projectView);
                Caption = itemView.FindViewById<TextView>(Resource.Id.ProjectTextView);

                // Detect user clicks on the item view and report which item
                // was clicked (by position) to the listener:
                itemView.Click += (sender, e) => listener(base.Position);
            }
        }
        public class ProjectAlbumAdapter : RecyclerView.Adapter
        {
            // Event handler for item clicks:
            public event EventHandler<int> ItemClick;

            // Underlying data set (a photo album):
            public ProjectAlbum mProjectAlbum;

            // Load the adapter with the data set (photo album) at construction time:
            public ProjectAlbumAdapter(ProjectAlbum projectAlbum)
            {
                mProjectAlbum = projectAlbum;
            }

            // Create a new photo CardView (invoked by the layout manager): 
            public override RecyclerView.ViewHolder
                OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                // Inflate the CardView for the photo:
                View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ProjectCardView, parent, false);

                // Create a ViewHolder to find and hold these view references, and 
                // register OnClick with the view holder:
                ProjectViewHolder vh = new ProjectViewHolder(itemView, OnClick);
                return vh;
            }

            // Fill in the contents of the photo card (invoked by the layout manager):
            public override void
                OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                ProjectViewHolder vh = holder as ProjectViewHolder;

                // Set the ImageView and TextView in this ViewHolder's CardView 
                // from this position in the photo album:
                vh.Image.SetImageResource(mProjectAlbum[position].ProjectID);
                vh.Caption.Text = mProjectAlbum[position].Caption;
            }

            // Return the number of photos available in the photo album:
            public override int ItemCount
            {
                get { return mProjectAlbum.NumProjects; }
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