using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackHandler : MonoBehaviour
{
    [SerializeField] GameObject trackPreFab;
    private float moveSpeed = 12f;
    private float distanceOfDeletion = -71f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (gameObject.transform.position.z <= distanceOfDeletion)
        {
            Destroy(gameObject.transform.GetChild(0).gameObject);
            distanceOfDeletion -= 71;
            GameObject temp = Instantiate(trackPreFab, Vector3.zero, Quaternion.identity);
            temp.transform.position = new Vector3(0, 0, gameObject.transform.GetChild(gameObject.transform.childCount - 1).transform.position.z + 71f);
            temp.transform.parent = gameObject.transform;
        }
        
    }
}
