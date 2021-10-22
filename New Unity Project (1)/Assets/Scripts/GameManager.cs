using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //BATTLEGROUND POSITION X 0.0017 Y 0.5613 Z 0
    //BATTLEGROUND SCALE 1.481725
    public int level = 1;
    public int enemiesToDefeat;
    public int playstyle; // 0 = swordsman, 1 = archer, 2 = mage
    public GameObject[] playstyles;
    public GameObject[] player;
    public int playerhealth = 3;
    GameObject door;
    //GameObject spawnmanager;
    SpawnManager spawnManagerScript;
    GameObject playerreal;
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameController");
        //spawnmanager = GameObject.FindGameObjectWithTag("Spawner");
        spawnManagerScript = FindObjectOfType<SpawnManager>();
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Door");
        playstyle = Random.Range(0, 3);
        Debug.Log(playstyle);
        Instantiate(playstyles[playstyle], new Vector3(-8.57f, 0.468f, 0), transform.rotation);
        //Debug.Log("yo");
    }

    // Update is called once per frame
    void Update()
    {
        enemiesToDefeat = level;
        EndGame();
        if (spawnManagerScript.enemiesdead == level)
        {
            Destroy(door.gameObject);
            level++;
            spawnManagerScript.enemiesdead = 0;
            
        }
        //Debug.Log(playerhealth);

    }
    private void EndGame()
    {
        if (playerhealth <= 0)
        {
            switch (playstyle)
            {
                case 0:
                    playerreal = GameObject.Find("Archie(Clone)");
                    Destroy(playerreal);
                    break;
                case 1:
                    playerreal = GameObject.Find("ArchieArcher 1(Clone)");
                    Destroy(playerreal);
                    break;
                case 2:
                    playerreal = GameObject.Find("ArchieMage(Clone)");
                    Destroy(playerreal);
                    break;
            }
            
        }
    }
}
