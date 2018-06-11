using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using V4Fragment = Android.Support.V4.App.Fragment;
using V4FragmentManager = Android.Support.V4.App.FragmentManager;
using Android.Widget;
using Android.Support.V4.App;

namespace Android_Freaks
{
    public class ViewPagerAdapter : FragmentPagerAdapter
    {
        V4Fragment[] _fragments;

        public ViewPagerAdapter(V4FragmentManager fm, V4Fragment[] fragments) : base(fm)
        {
            _fragments = fragments;
        }

        public override int Count => _fragments.Length;

        public override V4Fragment GetItem(int position) => _fragments[position];
    }
}