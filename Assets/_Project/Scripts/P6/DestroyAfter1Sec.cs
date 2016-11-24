using System.Collections;
using UnityEngine;

namespace Assets._Project.Scripts.P6
{
    public class DestroyAfter1Sec : MonoBehaviour
    {
        private bool isRoutineStarted = false;

        void Update ()
        {
            if (!isRoutineStarted)
            {
                StartCoroutine(PaintAndDestroyRoutine(Time.time));
                isRoutineStarted = true;
            }
        }

        IEnumerator DestroyRoutine(float startTime)
        {
            while (Time.time < startTime + 5f)
            {
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject);
        }

        IEnumerator PaintAndDestroyRoutine(float startTime)
        {
            while (Time.time < startTime + 5f)
            {
                yield return new WaitForEndOfFrame();
            }
            gameObject.GetComponent<Renderer>().material = Resources.Load("RedMat") as Material;

            while (Time.time < startTime + 10f)
            {
                yield return new WaitForEndOfFrame();
            }

            gameObject.GetComponent<Transform>().localScale = Vector3.one*5f;

            while (Time.time < startTime + 15f)
            {
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject);
        }
    }
}
