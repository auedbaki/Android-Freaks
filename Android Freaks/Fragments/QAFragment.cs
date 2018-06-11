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

namespace Android_Freaks
{
    public class QAFragment : V4Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            HasOptionsMenu = true;
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.Fragment_qa, container, false);

            return view;
        }

        internal static V4Fragment NewInstance()
        {
            return new QAFragment();
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
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