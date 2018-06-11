using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using V4Fragment = Android.Support.V4.App.Fragment;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using System;

namespace Android_Freaks
{
    [Activity(Label = "Android Freaks", MainLauncher = true, Theme ="@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        private BottomNavigationView bottomNavigation;
        private ViewPager viewPager;
        private V4Fragment[] fragments;
        private V7Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            InitilizeFragments();
            toolbar = FindViewById<V7Toolbar>(Resource.Id.my_toolbar);
            toolbar.Title = "Android Freaks";
            SetSupportActionBar(toolbar);
            
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.baseline_menu_24);
            bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            viewPager.Adapter = new ViewPagerAdapter(SupportFragmentManager, fragments);
            bottomNavigation.NavigationItemSelected += BottomNavigation_NavigationItemSelected;
            bottomNavigation.NavigationItemReselected += BottomNavigation_NavigationItemReselected;
            
            viewPager.PageSelected += ViewPager_PageSelected;
           
        }
        public override void OnBackPressed()
        {
            if(bottomNavigation.SelectedItemId==Resource.Id.menu_home)
            base.OnBackPressed();
            else
            {
                bottomNavigation.SelectedItemId = Resource.Id.menu_home;
                viewPager.SetCurrentItem(0, true);
            }
        }
        private void InitilizeFragments()
        {
            fragments = new V4Fragment[]
            {
                HomeFragment.NewInstance(),
                QAFragment.NewInstance(),
                AboutFragment.NewInstance()

            };
        }

        private void ViewPager_PageSelected(object sender, ViewPager.PageSelectedEventArgs e)
        {
            var item = bottomNavigation.Menu.GetItem(e.Position);
            bottomNavigation.SelectedItemId = item.ItemId;
        }

        private void BottomNavigation_NavigationItemReselected(object sender, BottomNavigationView.NavigationItemReselectedEventArgs e)
        {
            
        }

        private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            viewPager.SetCurrentItem(e.Item.Order, true);
        }

        //void RemoveShiftMode(BottomNavigationView view)
        //{
        //    var menuView = (BottomNavigationMenuView)view.GetChildAt(0);
        //    try
        //    {
        //        var shiftingMode = menuView.Class.GetDeclaredField("mShiftingMode");
        //        shiftingMode.Accessible = true;
        //        shiftingMode.SetBoolean(menuView, false);
        //        shiftingMode.Accessible = false;

        //        for (int i = 0; i < menuView.ChildCount; i++)
        //        {
        //            var item = (BottomNavigationItemView)menuView.GetChildAt(i);
        //            item.SetShiftingMode(false);
        //            // set checked value, so view will be updated
        //            item.SetChecked(item.ItemData.IsChecked);
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine((ex.InnerException ?? ex).Message);
        //    }
        //}

    }
}

