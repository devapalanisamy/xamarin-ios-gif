using System;

using UIKit;
using CoreGraphics;

namespace GifApp
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			GifImageView.Image = UIImage.FromFile ("Gif Images/tmp-1.png");

			GifImageView.AnimationImages = new UIImage[]{
				UIImage.FromFile ("Gif Images/tmp-0.png")
				,UIImage.FromFile ("Gif Images/tmp-1.png")
				,UIImage.FromFile ("Gif Images/tmp-2.png")
				,UIImage.FromFile ("Gif Images/tmp-3.png")
				,UIImage.FromFile ("Gif Images/tmp-4.png")
				,UIImage.FromFile ("Gif Images/tmp-5.png")
			};

			GifImageView.AnimationRepeatCount = 0;
			GifImageView.AnimationDuration = .5;
			GifImageView.StartAnimating();

		}
	}
}

