// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace EducationApp.iOS.ViewControllers
{
	[Register ("SubscribeViewController")]
	partial class SubscribeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton AddParticipantButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBarItem ContactTabBarItem { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView DataTable { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBarItem FeedbackTabBarItem { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBarItem ScheduleTabBarItem { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SendSubscriptionButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBarItem SubscribeTabBarItem { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITabBar TabBar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView TvPleaseLogin { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AddParticipantButton != null) {
				AddParticipantButton.Dispose ();
				AddParticipantButton = null;
			}
			if (ContactTabBarItem != null) {
				ContactTabBarItem.Dispose ();
				ContactTabBarItem = null;
			}
			if (DataTable != null) {
				DataTable.Dispose ();
				DataTable = null;
			}
			if (FeedbackTabBarItem != null) {
				FeedbackTabBarItem.Dispose ();
				FeedbackTabBarItem = null;
			}
			if (ScheduleTabBarItem != null) {
				ScheduleTabBarItem.Dispose ();
				ScheduleTabBarItem = null;
			}
			if (SendSubscriptionButton != null) {
				SendSubscriptionButton.Dispose ();
				SendSubscriptionButton = null;
			}
			if (SubscribeTabBarItem != null) {
				SubscribeTabBarItem.Dispose ();
				SubscribeTabBarItem = null;
			}
			if (TabBar != null) {
				TabBar.Dispose ();
				TabBar = null;
			}
			if (TvPleaseLogin != null) {
				TvPleaseLogin.Dispose ();
				TvPleaseLogin = null;
			}
		}
	}
}
