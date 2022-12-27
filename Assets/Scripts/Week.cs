using Sirenix.OdinInspector;

namespace Assets.Scripts
{
    [System.Serializable]
    public class Week
    {
        [TableList(ShowIndexLabels = true)]
        public Day[] days = new Day[7];
    }
}
