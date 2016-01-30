using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Custom_Scenery.Decorators;
using UnityEngine;

namespace Custom_Scenery.CustomScenery.Decorators
{
    class GridSubdivisionDecorator : IDecorator
    {
        private float _subdivision;

        public GridSubdivisionDecorator(double subdivision)
        {
            _subdivision = (float)subdivision;
        }

        public void Decorate(GameObject go, Dictionary<string, object> options, AssetBundle assetBundle)
        {
            if (go.GetComponent<Deco>() != null)
            {
                go.GetComponent<Deco>().defaultGridSubdivision = _subdivision;
            }
        }
    }
}
