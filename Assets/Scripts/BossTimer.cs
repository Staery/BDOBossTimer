using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class BossTimer : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI timerTime;
        [SerializeField] TextMeshProUGUI nameBoss;
        [SerializeField] Image imgBossOne;
        [SerializeField] Image imgBossTwo;
        [SerializeField] Servers[] serversStruct;
        private int hours;
        private int minutes;

        private void OnEnable()
        {
            StartCoroutine(StartTimer(hours, minutes));
        }
        private void OnDisable()
        {
            StopAllCoroutines();
        }

        private void intervalSearch()
        {
            
        }

        private IEnumerator StartTimer(int _hours, int _minutes)
        {
            TimeSpan interval = new TimeSpan(_hours, _minutes, 0);

            while (true)
            {

                timerTime.text = interval.ToString();
                yield return new WaitForSeconds(1);
                interval -= TimeSpan.FromSeconds(1);
            }
        }
    }


}