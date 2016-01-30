using System.Collections.Generic;
using UnityEngine;

namespace Custom_Scenery.Decorators
{
    class PriceDecorator : IDecorator
    {
        private double _price;

        public PriceDecorator(double price)
        {
            _price = price;
        }

        public void Decorate(GameObject go, Dictionary<string, object> options, AssetBundle assetBundle)
        {
            go.GetComponent<BuildableObject>().price = (float) _price;
        }
    }
}
