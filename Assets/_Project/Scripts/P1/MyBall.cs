using Assets._Project.Scripts.P2;
using UnityEngine;

namespace Assets._Project.Scripts.P1
{
    public class MyBall : MonoBehaviour
    {
        public MyCube MyCube;
        public bool IsMyCubeRotating;
	
        void Update () {
            if (IsMyCubeRotating)
            {
                MyCube.GetComponent<Transform>().Rotate(Vector3.up, C.RotateSpeed);
            }

            C.RotateSpeed = 5*Mathf.Sin(Time.time);
        }
    }
}
