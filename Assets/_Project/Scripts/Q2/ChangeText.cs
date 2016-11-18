using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.Q2
{
    public class ChangeText : MonoBehaviour
    {
        public Text UnityText;

        void Start()
        {
            UnityText = GetComponent<Text>();
        }

        void Update()
        {
            UnityText.text = DateTime.Now.ToString();
        }
    }
}
