using System;
using Android.Widget;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;

namespace Wandertrust
{
	public class ResizableImageView : ImageView {

		public ResizableImageView (Context context) :
		base(context)
		{
			Initialize ();
		}

		public ResizableImageView (Context context, IAttributeSet attrs) :
		base (context, attrs)
		{
			Initialize ();
		}

		public ResizableImageView (Context context, IAttributeSet attrs, int defStyle) :
		base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
		}

		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			Drawable d = Drawable;

			if (d != null) 
			{
				int width = MeasureSpec.GetSize(widthMeasureSpec);
				int height = (int) Math.Ceiling((float) width * (float) d.IntrinsicHeight / (float) d.IntrinsicWidth);
				SetMeasuredDimension(width, height);
			} else
			{
				base.OnMeasure (widthMeasureSpec, heightMeasureSpec);
			}
		}

	}
}

