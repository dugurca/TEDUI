using UnityEngine;

namespace Assets._Project.Scripts.P6
{
    public class CreateBalls : MonoBehaviour
    {
        void Update ()
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position = transform.position;
            go.AddComponent<Rigidbody>();
            go.AddComponent<DestroyAfter1Sec>();
        }
    }
}
