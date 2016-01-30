using System.Collections.Generic;
using UnityEngine;

namespace Custom_Scenery.Decorators.Type
{
    class SeatingDecorator : IDecorator
    {
        public void Decorate(GameObject go, Dictionary<string, object> options, AssetBundle assetBundle)
        {
            if (options.ContainsKey("seatingOptions"))
            {
                Dictionary<string, object> seatingOptions = options["seatingOptions"] as Dictionary<string, object>;
                
                go.AddComponent<Seating>();

                go.GetComponent<Seating>().hasBackRest = (bool)seatingOptions["hasBackRest"];
            }
        }
    }
}
