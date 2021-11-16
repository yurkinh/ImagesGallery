using System;
using System.Linq;
using ImageGallery.Helpers;
using Xamarin.Forms;

namespace ImageGallery
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableRangeCollection<ImageSource> images = new(ImageHelper.GetPicsumImages(5).ToArray());
        public MainPage()
        {
            InitializeComponent();
            BindingContext = images;
            //Using Glidex for Android imasge caching
            //Using Nuke for ios image caching
        }

        void CollectionView_RemainingItemsThresholdReached(object sender, EventArgs e)=>
            images.AddRange(ImageHelper.GetPicsumImages(5).ToArray());

    }
}
