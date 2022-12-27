using Sirenix.OdinInspector;

namespace Assets.Scripts
{
    [System.Serializable]
    public class Day
    {
        [TableList(ShowIndexLabels = false)]
        public SpawnEvent[] spawnEvent;
    }
}
