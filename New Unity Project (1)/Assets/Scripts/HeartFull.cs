using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartFull : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("threehearts");
        //spawnmanager = GameObject.FindGameObjectWithTag("Spawner");

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
