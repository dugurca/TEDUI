using UnityEngine;

namespace Assets._Project.Scripts.P3
{
    public class Ternary : MonoBehaviour {
        void Update ()
        {
            GameObject go = Random.value > 0.5f ? 
                GameObject.CreatePrimitive(PrimitiveType.Cube) : 
                GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.AddComponent<Rigidbody>();
            go.transform.position = transform.position;
        }
    }
}






















/*
GameObject go = Random.value > 0.5 ? 
    GameObject.CreatePrimitive(PrimitiveType.Sphere): 
    GameObject.CreatePrimitive(PrimitiveType.Cube);
*/
