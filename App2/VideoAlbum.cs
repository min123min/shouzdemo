namespace App2
{
  

        public class Video
        {

            // Photo ID for this photo:
            public int mVideoID;

            // Caption text for this photo:
            public string mCaption;

            // Return the ID of the photo:
            public int VideoID
            {
                get { return mVideoID; }
            }

            // Return the Caption of the photo:
            public string Caption
            {
                get { return mCaption; }
            }
        }

        // Photo album: holds image resource IDs and caption:
        public class VideoAlbum
        {
            // Built-in photo collection - this could be replaced with
            // a photo database:

            static Video[] mBuiltInPhotos = {
            new Video { mVideoID = Resource.Drawable.Icon,  mCaption = "Buckingham Palace" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "The Eiffel Tower" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "The Louvre" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Before mobile phones" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Big Ben skyline" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Big Ben from below" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "The London Eye" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Eurostar Train" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Arc de Triomphe" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Inside the Louvre" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Versailles fountains" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Modest accomodations" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Notre Dame" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Inside Notre Dame" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "The Seine" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Rue Cler" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "The Avenue des Champs-Elysees" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Seine barge" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Gates of Versailles" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh Castle" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh Castle up close" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Old meets new" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh from on high" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh station" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Scott Monument" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "View from Holyrood Park" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Outside the Tower of London" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Tower of London visitors" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "One O'Clock Gun" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Victoria and Albert Museum" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "The Royal Mile" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Edinburgh Museum and Castle" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Portcullis Gate" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Left or right?" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Pompidou Centre" },
            new Video { mVideoID = Resource.Drawable.Icon,
                        mCaption = "Here's Lookin' at Ya!" },
            };

            // Array of photos that make up the album:
            private Video[] mVideos;

            // Random number generator for shuffling the photos:

            // Create an instance copy of the built-in photo list and
            // create the random number generator:
            public VideoAlbum()
            {
                mVideos = mBuiltInPhotos;

            }

            // Return the number of photos in the photo album:
            public int NumVideos
            {
                get { return mVideos.Length; }
            }

            // Indexer (read only) for accessing a photo:
            public Video this[int i]
            {
                get { return mVideos[i]; }
            }

            // Pick a random photo and swap it with the top:


            // Shuffle the order of the photos:

        }

    }
