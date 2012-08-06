using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Linq;

namespace SQLite
{
	public partial class SQLiteViewController : UIViewController
	{
		public SQLiteViewController () : base ("SQLiteViewController", null)
		{
			InitializeDatabase ();
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
		
		protected void InitializeDatabase ()
		{
			var dbName = "people";
			var conn = new SQLiteAsyncConnection (dbName);
			conn.CreateTableAsync<Person> ().ContinueWith ((task) =>
			{
				foreach (var i in Enumerable.Range (0,1000)) {
					var p = new Person ("Bob");
					conn.InsertAsync (p).ContinueWith ((task2) =>
					{
						var id = p.Id;
						this.InvokeOnMainThread (delegate {
							this.recordCount.Text = id.ToString ();
							this.recordCount.SetNeedsDisplay ();
						}
						);
					}
					);
				}
			}
			);
		}
	}
}

