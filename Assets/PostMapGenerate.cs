using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Data;

namespace MapAccessibilityProject.Assets
{

    internal class PostMapGenerate
    {

        public event Action OnMapboxFinishedRendering;

        public PostMapGenerate(AbstractMapVisualizer t)
        {
            t.OnTileFinished += AddSoundToObjects;
        }
        
        public void AddSoundToObjects(UnityTile t)
        {
            //t.gameObject.GetComponent()
        }
    }
}
