using Sirenix.OdinInspector;

namespace Assets.Scripts
{
    [System.Serializable]
    public class SpawnEvent
    {
        [HorizontalGroup("Time")]
        [VerticalGroup("Time/a"), LabelWidth(50), LabelText("HH:MM")]
        public int hours;
        [VerticalGroup("Time/b"), LabelWidth(7), LabelText(":")]
        public int minutes;
        [LabelText("Bosses")]
        public BossSO[] bosses;
    }
}
