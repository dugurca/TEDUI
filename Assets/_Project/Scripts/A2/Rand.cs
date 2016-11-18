using UnityEngine;

namespace Assets._Project.Scripts.A2
{
    public class Rand : MonoBehaviour
    {
        void Start ()
        {
            var randVal = Random.value;
            Debug.LogWarning(randVal);

            var randRot = Random.rotation;
            Debug.LogWarning(randRot);

            var randCircle = Random.insideUnitCircle;
            Debug.LogWarning(randCircle);

            var randSphere = Random.insideUnitSphere;
            Debug.LogWarning(randSphere);

            var randColor = Random.ColorHSV(0, 1);
            Debug.LogWarning(randColor);
        }
    }
}
