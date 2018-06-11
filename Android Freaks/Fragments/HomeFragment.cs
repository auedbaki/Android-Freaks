using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using V4Fragment = Android.Support.V4.App.Fragment;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;

namespace Android_Freaks
{
    public class HomeFragment : V4Fragment
    {
        private SwipeRefreshLayout swipeRefreshLayout;
        private RecyclerView recyclerView;
        
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            HasOptionsMenu = true;
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view =  inflater.Inflate(Resource.Layout.Fragment_home, container, false);
            swipeRefreshLayout = view.FindViewById<SwipeRefreshLayout>(Resource.Id.swipelayout_home);
            recyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerview_home);
            swipeRefreshLayout.Refresh += SwipeRefreshLayout_Refresh;
           
            Initialize();
            return view;
        }

        private void Initialize()
        {
            
        }

        private void SwipeRefreshLayout_Refresh(object sender, EventArgs e)
        {
            
        }

        internal static V4Fragment NewInstance()
        {
            return new HomeFragment();
        }
        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.bottom_navigation, menu);
            base.OnCreateOptionsMenu(menu, inflater);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch(item.ItemId)
            {

            }
            return base.OnOptionsItemSelected(item);
        }
    }
}