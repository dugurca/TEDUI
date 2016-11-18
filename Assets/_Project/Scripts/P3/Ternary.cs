using UnityEngine;

namespace Assets._Project.Scripts.P3
{
    public class Ternary : MonoBehaviour {
        void Update ()
        {
            GameObject go;
            if (Random.value > 0.5f)
            {
                go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            }
            else
            {
                go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
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
