using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.Q3
{
    public class CreateCubesWithSlider : MonoBehaviour
    {
        public Slider MySlider;

        public void Create()
        {
            for (int i = 0; i < MySlider.value; i++)
            {
                var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position = Vector3.up;
                go.AddComponent<Rigidbody>();
                go.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * 25f;
            }
        }
    }
}
