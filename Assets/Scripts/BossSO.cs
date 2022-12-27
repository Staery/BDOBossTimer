using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "BossSO", menuName = "BossSO", order = 0)]
    public class BossSO : ScriptableObject
    {
        [SerializeField]
        public string bossNume;

        [SerializeField]
        public Sprite imageBoss;
    }
}