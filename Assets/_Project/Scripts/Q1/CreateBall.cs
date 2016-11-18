using UnityEngine;

namespace Assets._Project.Scripts.Q1
{
    public class CreateBall : MonoBehaviour {
        public void Create()
        {
            var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position = Vector3.up;
            go.AddComponent<Rigidbody>();
            go.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * 10f);
        }
    }
}
