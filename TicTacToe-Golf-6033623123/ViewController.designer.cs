// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TicTacToeGolf6033623123
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton button1Prop { get; set; }

		[Outlet]
		AppKit.NSButton button2Prop { get; set; }

		[Outlet]
		AppKit.NSButton button3Prop { get; set; }

		[Outlet]
		AppKit.NSButton button4Prop { get; set; }

		[Outlet]
		AppKit.NSButton button5Prop { get; set; }

		[Outlet]
		AppKit.NSButton button6Prop { get; set; }

		[Outlet]
		AppKit.NSButton button7Prop { get; set; }

		[Outlet]
		AppKit.NSButton button8Prop { get; set; }

		[Outlet]
		AppKit.NSButton button9Prop { get; set; }

		[Outlet]
		AppKit.NSTextField mainLabel { get; set; }

		[Action ("onClickButton1:")]
		partial void onClickButton1 (AppKit.NSButton sender);

		[Action ("onClickButton2:")]
		partial void onClickButton2 (AppKit.NSButton sender);

		[Action ("onCLickButton2:")]
		partial void onCLickButton2 (Foundation.NSObject sender);

		[Action ("onClickButton3:")]
		partial void onClickButton3 (AppKit.NSButton sender);

		[Action ("onClickButton4:")]
		partial void onClickButton4 (AppKit.NSButton sender);

		[Action ("onClickButton5:")]
		partial void onClickButton5 (AppKit.NSButton sender);

		[Action ("onClickButton6:")]
		partial void onClickButton6 (AppKit.NSButton sender);

		[Action ("onClickButton7:")]
		partial void onClickButton7 (AppKit.NSButton sender);

		[Action ("onClickButton8:")]
		partial void onClickButton8 (AppKit.NSButton sender);

		[Action ("onClickButton9:")]
		partial void onClickButton9 (AppKit.NSButton sender);

		[Action ("onClickReset:")]
		partial void onClickReset (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (button2Prop != null) {
				button2Prop.Dispose ();
				button2Prop = null;
			}

			if (button3Prop != null) {
				button3Prop.Dispose ();
				button3Prop = null;
			}

			if (button4Prop != null) {
				button4Prop.Dispose ();
				button4Prop = null;
			}

			if (button5Prop != null) {
				button5Prop.Dispose ();
				button5Prop = null;
			}

			if (button6Prop != null) {
				button6Prop.Dispose ();
				button6Prop = null;
			}

			if (button7Prop != null) {
				button7Prop.Dispose ();
				button7Prop = null;
			}

			if (button8Prop != null) {
				button8Prop.Dispose ();
				button8Prop = null;
			}

			if (button9Prop != null) {
				button9Prop.Dispose ();
				button9Prop = null;
			}

			if (mainLabel != null) {
				mainLabel.Dispose ();
				mainLabel = null;
			}

			if (button1Prop != null) {
				button1Prop.Dispose ();
				button1Prop = null;
			}
		}
	}
}
