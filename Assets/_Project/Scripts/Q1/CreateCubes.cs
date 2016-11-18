using UnityEngine;

namespace Assets._Project.Scripts.Q1
{
    public class CreateCubes : MonoBehaviour
    {
        public void Create(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position = Vector3.up;
                go.AddComponent<Rigidbody>();
                go.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere*25f;
            }
        }
    }
}
