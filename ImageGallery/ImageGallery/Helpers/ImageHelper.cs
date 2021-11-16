using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ImageGallery.Helpers
{
    public static  class ImageHelper
    {
		static readonly Random random = new();		
		
		public static IEnumerable<ImageSource> GetPicsumImages(int count)
		{
			var width = (int)(DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density);
			var url = $"https://picsum.photos/{width}/200";

			for (int i = 0; i < count; i++)
			{
				yield return ImageSource.FromUri(new Uri($"{url}?{random.Next()}"));
			}
		}
	}
}
