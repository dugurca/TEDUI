using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.Q4
{
    public class Scroller : MonoBehaviour
    {
        public Scrollbar myScrollbar;
        
        void Start ()
        {
            myScrollbar = GetComponent<Scrollbar>();
        }
	
        void Update ()
        {
            myScrollbar.value = Mathf.Abs(Mathf.Sin(Time.time));
        }
    }
}
