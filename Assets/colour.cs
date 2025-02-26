using System.Threading;
using UnityEngine;

public class colour : MonoBehaviour
{
    private void Start()
    {
      
    }
    void Update()
    {
     transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);

    }
}
