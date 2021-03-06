// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace Todo11App
{
	public partial class TodoCell : UICollectionViewCell
	{
		public TodoCell (IntPtr handle) : base (handle)
		{
		}

		bool isDone;
		public void SetData (TodoItem todo) 
		{
			Name.Text = todo.Name;
			isDone = todo.Done;

			if (isDone)
				Done.Image = UIImage.FromBundle ("checkbox");
			else
				Done.Image = UIImage.FromBundle ("box");

		}

		public override bool IsAccessibilityElement {
			get {
				return true;
			}
			set {
				base.IsAccessibilityElement = value;
			}
		}

		public override string AccessibilityLabel {
			get 
			{
				return Name.Text + (isDone?" is done":" is not complete");	
			}
			set 
			{
				base.AccessibilityLabel = value;
			}
		}

		/// <summary>
		/// Expose the check/box image
		/// </summary>
		public UIKit.UIImageView Done { get { return DoneImage; } }

		/// <summary>
		/// Expose the label
		/// </summary>
		public UIKit.UILabel Name { get{ return TodoName; } }
	}
}
