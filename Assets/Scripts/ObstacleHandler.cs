using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField] GameObject obstaclePreFab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= Random.Range(2, 4); i++)
        {
            GameObject temp = Instantiate(obstaclePreFab, new Vector3(Random.Range(-6.5f, 6.5f), 1, Random.Range(transform.position.z - 23, transform.position.z + 23)), Quaternion.identity);
            temp.transform.parent = gameObject.transform;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
