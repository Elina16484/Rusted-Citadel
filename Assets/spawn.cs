using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject X;
    private float Number = 5;
    private float Radius = 10;
    public float min = 5;
    public float max = 15;

    public void CreateCube()
    {
        for (int i = 0; i < Number; i++)
        {
            Vector3 randomPos = Random.insideUnitCircle * Radius;
            randomPos.y = Random.Range(min, max);
            Instantiate(X, transform.position + randomPos, Quaternion.identity);

        } 
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);

        CreateCube();
    }
}
