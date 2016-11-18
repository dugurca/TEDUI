using UnityEngine;

namespace Assets._Project.Scripts.A
{
    public class Mat : MonoBehaviour
    {
        void Start () {
            Debug.LogWarning(Mathf.Abs(-3.15f));
            Debug.LogWarning(Mathf.Approximately(0.000000019f, 0.000000018f));
            Debug.LogWarning(Mathf.Approximately(1f - Mathf.Epsilon, 1f + Mathf.Epsilon));
            Debug.LogWarning(Mathf.PI);

            
        }




















        void Update()
        {
            //Debug.Log(Mathf.Sin(Time.time));
            //Debug.Log(Mathf.Abs(Mathf.Cos(Time.time)));
        }
    }
}
