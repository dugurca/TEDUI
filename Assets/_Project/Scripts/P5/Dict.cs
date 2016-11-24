using System.Collections.Generic;
using UnityEngine;

namespace Assets._Project.Scripts.P5
{
    public class Dict : MonoBehaviour
    {
        Dictionary<int, List<GameObject>> _goDict = new Dictionary<int, List<GameObject>>();
        void Start()
        {
            _goDict.Add(1, new List<GameObject>());
            _goDict.Add(2, new List<GameObject>());
            _goDict.Add(3, new List<GameObject>());
        }
	
        void Update ()
        {
            ClearBalls();
            if (Random.value < 0.8f) return;
            
            var go = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            go.AddComponent<Rigidbody>();
            go.transform.position = transform.position;
            go.transform.rotation = Quaternion.Euler(Random.insideUnitSphere * 360f);

            if (Random.value < 0.333)
            {
                go.transform.localScale = Vector3.one;
                _goDict[1].Add(go);
            }
            else if (Random.value < 0.666)
            {
                go.transform.localScale = Vector3.one*2;
                _goDict[2].Add(go);
            }
            else
            {
                go.transform.localScale = Vector3.one * 3;
                _goDict[3].Add(go);
            }
        }


        void ClearBallsInList(List<GameObject> lst)
        {
            foreach (var go in lst)
            {
                Destroy(go);
            }
            lst.Clear();
        }

        void ClearBalls()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ClearBallsInList(_goDict[1]);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                ClearBallsInList(_goDict[2]);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                ClearBallsInList(_goDict[3]);
            }
        }
    }
}
