using System.Collections.Generic;
using UnityEngine;

namespace Assets._Project.Scripts.P4
{
    public class BallsList : MonoBehaviour
    {
        public List<GameObject> Balls = new List<GameObject>();
        public List<GameObject> Cubes = new List<GameObject>();

        void Update()
        {
            if (Random.value < 0.9f) return;

            GameObject go;
            if (Random.value > 0.5)
            {
                go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Balls.Add(go);
            }
            else
            {
                go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Cubes.Add(go);
            }

            go.AddComponent<Rigidbody>();
            go.transform.position = transform.position;
        }




        void ClearBalls()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                foreach (var ball in Balls)
                {
                    Destroy(ball);
                }
                Balls.Clear();
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                foreach (var cube in Cubes)
                {
                    Destroy(cube);
                }
                Cubes.Clear();
            }
        }
    }
}
