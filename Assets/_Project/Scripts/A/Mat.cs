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

            for (int i = 0; i < 100000; i++)
            {
                Debug.LogWarning(Mathf.PerlinNoise(i, Time.time));
            }
        }
    }
}
