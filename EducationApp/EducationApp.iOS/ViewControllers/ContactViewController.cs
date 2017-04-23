using System;
using System.Collections.Generic;
using EducationApp.iOS.Utilities;
using EducationApp.ViewModels;
using EducationApp.ViewModels.Utilities;
using GalaSoft.MvvmLight.Helpers;
using UIKit;

namespace EducationApp.iOS.ViewControllers
{
    partial class ContactViewController : BaseViewController
    {
        public ContactViewController(IntPtr handle) : base(handle)
        {
            DelayedActivation = true;
            DelayedParameter = true;
        }

        private SessionViewModel Vm => Application.Locator.SessionViewModel;

        protected override ViewModelBase GetViewModel() => Vm;

        public override void ViewDidLoad()
        {
            CurrentNavigationItem = NavigationItem;
            base.ViewDidLoad();

            TabBar.ItemSelected += NavigateOnTabBar;
            Title = Application.Locator.CourseViewModel.Course.Title;
            IdentityChanged();

            TabBar.SelectedItem = ContactTabBarItem;

            BtSendContactForm.SetCommand("TouchUpInside", Vm.SendContactFormCommand);
            var gestureRecognizer = new UITapGestureRecognizer(() => View.EndEditing(true));
            View.AddGestureRecognizer(gestureRecognizer);
        }

        protected override TabBarItemType GetTabBarItemType(UITabBarItem item)
        {
            if (item == ScheduleTabBarItem)
            {
                return TabBarItemType.Schedule;
            }
            if (item == ContactTabBarItem)
            {
                return TabBarItemType.Contact;
            }
            if (item == FeedbackTabBarItem)
            {
                return TabBarItemType.Feedback;
            }
            if (item == SubscribeTabBarItem)
            {
                return TabBarItemType.Subscribe;
            }

            return base.GetTabBarItemType(item);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            TabBar.ItemSelected -= NavigateOnTabBar;
        }

        protected override IEnumerable<Binding> SetBindings() => new List<Binding>
        {
            this.SetBinding(() => TvSubject.Text, Application.Locator.SessionViewModel,
                () => Application.Locator.SessionViewModel.ContactForm.Subject).UpdateSourceTrigger("EditingDidEnd"),
            this.SetBinding(() => TvMessage.Text, Application.Locator.SessionViewModel,
                () => Application.Locator.SessionViewModel.ContactForm.Body).UpdateSourceTrigger("Changed"),
            Application.Locator.SessionViewModel.SetBinding(() => Application.Locator.SessionViewModel.Identity)
                .WhenSourceChanges(ShowLoginText)
        };
    }
}