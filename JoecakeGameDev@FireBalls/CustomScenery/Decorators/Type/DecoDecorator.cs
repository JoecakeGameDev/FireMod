using System.Collections.Generic;
using Custom_Scenery.CustomScenery.Decorators;
using UnityEngine;

namespace Custom_Scenery.Decorators.Type
{
    class DecoDecorator : IDecorator
    {
        public void Decorate(GameObject go, Dictionary<string, object> options, AssetBundle assetBundle)
        {
            go.AddComponent<Deco>();

            if (options.ContainsKey("heightDelta"))
                (new HeightDecorator((double)options["heightDelta"])).Decorate(go, options, assetBundle);

            if (options.ContainsKey("gridSubdivision"))
                (new GridSubdivisionDecorator((double)options["gridSubdivision"])).Decorate(go, options, assetBundle);

            if (options.ContainsKey("snapCenter"))
                (new SnapToCenterDecorator((bool)options["snapCenter"])).Decorate(go, options, assetBundle);
        }
    }
}
