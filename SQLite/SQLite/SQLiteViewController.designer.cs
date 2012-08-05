// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SQLite
{
	[Register ("SQLiteViewController")]
	partial class SQLiteViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel recordCount { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (recordCount != null) {
				recordCount.Dispose ();
				recordCount = null;
			}
		}
	}
}
