using System.Collections.Generic;
using UnityEngine;

namespace Custom_Scenery.Decorators.Type
{
    class TrashBinDecorator : IDecorator
    {
        public void Decorate(GameObject go, Dictionary<string, object> options, AssetBundle assetBundle)
        {
            go.AddComponent<TrashBin>();
        }
    }
}
