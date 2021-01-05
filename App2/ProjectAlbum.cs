using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App2
{
    public class Project
    {


        // Photo ID for this photo:
        public int mProjectID;

        // Caption text for this photo:
        public string mCaption;

        // Return the ID of the photo:
        public int ProjectID
        {
            get { return mProjectID; }
        }

        // Return the Caption of the photo:
        public string Caption
        {
            get { return mCaption; }
        }
    }

    // Photo album: holds image resource IDs and caption:
    public class ProjectAlbum
    {
        // Built-in photo collection - this could be replaced with
        // a photo database:

        static Project[] mBuiltInProjects = {
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Buckingham Palace" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "The Eiffel Tower" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "The Louvre" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Before mobile phones" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Big Ben skyline" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Big Ben from below" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "The London Eye" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Eurostar Train" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Arc de Triomphe" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Inside the Louvre" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Versailles fountains" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Modest accomodations" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Notre Dame" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Inside Notre Dame" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "The Seine" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Rue Cler" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "The Avenue des Champs-Elysees" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Seine barge" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Gates of Versailles" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh Castle" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh Castle up close" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Old meets new" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh from on high" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh station" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Scott Monument" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "View from Holyrood Park" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Outside the Tower of London" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Tower of London visitors" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "One O'Clock Gun" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Victoria and Albert Museum" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "The Royal Mile" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh Museum and Castle" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Portcullis Gate" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Left or right?" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Pompidou Centre" },
            new Project { mProjectID = Resource.Drawable.Icon,
                        mCaption = "Here's Lookin' at Ya!" },
            };

        // Array of photos that make up the album:
        private Project[] mProjects;

        // Random number generator for shuffling the photos:

        // Create an instance copy of the built-in photo list and
        // create the random number generator:
        public ProjectAlbum()
        {
            mProjects = mBuiltInProjects;

        }

        // Return the number of photos in the photo album:
        public int NumProjects
        {
            get { return mProjects.Length; }
        }

        // Indexer (read only) for accessing a photo:
        public Project this[int i]
        {
            get { return mProjects[i]; }
        }

        // Pick a random photo and swap it with the top:


        // Shuffle the order of the photos:

    }
}