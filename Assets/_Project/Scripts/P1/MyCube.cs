using UnityEngine;

namespace Assets._Project.Scripts.P1
{
    public class MyCube : MonoBehaviour
    {
        public MyBall MyBall;
        public bool IsMyBallScaling;

        void Update () {
            if (IsMyBallScaling)
            {
                float scale = Mathf.Sin(Time.time);
                var scaleVec = new Vector3(scale, scale, scale);
                MyBall.GetComponent<Transform>().localScale = scaleVec * 3f;
            }
        }
    }
}
