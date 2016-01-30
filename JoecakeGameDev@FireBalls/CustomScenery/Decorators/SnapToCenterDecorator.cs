using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Custom_Scenery.Decorators;
using UnityEngine;

namespace Custom_Scenery.CustomScenery.Decorators
{
    class SnapToCenterDecorator : IDecorator
    {
        private bool _snap;

        public SnapToCenterDecorator(bool snap)
        {
            _snap = snap;
        }

        public void Decorate(GameObject go, Dictionary<string, object> options, AssetBundle assetBundle)
        {
            if (go.GetComponent<Deco>() != null)
            {
                go.GetComponent<Deco>().defaultSnapToGridCenter = _snap;
            }
        }
    }
}
