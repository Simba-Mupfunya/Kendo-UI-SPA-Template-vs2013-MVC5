﻿using System;
using System.Web.Optimization;

namespace demo
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

            bundles.Add(
              new ScriptBundle("~/scripts/vendor")
                .Include("~/scripts/jquery-{version}.js")
                .Include("~/scripts/pubsub.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/scripts/debug.js")
              );

            bundles.Add(
              new StyleBundle("~/Content/css")
                .Include("~/Content/kendo/2014.1.416/kendo.common-bootstrap.min.css")
                .Include("~/Content/kendo/2014.1.416/kendo.bootstrap.min.css")
                .Include("~/Content/kendo/2014.1.416/kendo.bootstrap.mobile.min.css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/font-awesome.css")
              );
        }

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
            {
                throw new ArgumentNullException("ignoreList");
            }

            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");

            //ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}