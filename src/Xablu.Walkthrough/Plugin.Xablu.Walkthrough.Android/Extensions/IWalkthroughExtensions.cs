﻿using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Plugin.Xablu.Walkthrough.Abstractions;
using Plugin.Xablu.Walkthrough.Defaults;
using Walker;

namespace Plugin.Xablu.Walkthrough
{
    public static class IWalkthroughExtensions
    {
        public static void Init(this IWalkthrough walkThrough, AppCompatActivity hostActivity)
        {
            var androidWalkThrough = (WalkthroughImplementation)walkThrough;
            androidWalkThrough.Init(hostActivity);
        }
    }
}
