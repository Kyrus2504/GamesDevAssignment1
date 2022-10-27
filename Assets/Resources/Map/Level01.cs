using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01 : MonoBehaviour
{
    int[,] levelMap = 
    { 
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7}, 
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4}, 
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4}, 
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4}, 
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3}, 
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5}, 
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4}, 
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3}, 
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4}, 
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4}, 
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3}, 
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0}, 
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0}, 
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0}, 
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0}, 
    }; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(levelMap[0, 0]);
        if (levelMap[0, 0] == 1){
            Debug.Log("So true bestie");
            GameObject OutsideCorner = Resources.Load<GameObject>("Map/GameObjects/OutsideCorner");
            OutsideCorner.transform.position = new Vector3(10.0f, 10.0f, 0.0f);
            Debug.Log(OutsideCorner.transform.position.x + " " + OutsideCorner.transform.position.y + " " + OutsideCorner.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MapGenerator(int[,] map){
        for (int i = 0; i < 12; i++){
            for (int j = 0; j < 14; j++){
                if (map[i, j] == 1){
                    GameObject OutsideCorner = Resources.Load<GameObject>("Assets/Map/GameObjects/OutsideCorner");
                    OutsideCorner.transform.position = new Vector3(10.0f + 1.0f*i, 10.0f + 1.0f*j, 0);
                }
                if (map[i, j] == 2){
                    GameObject OutsideCorner = Resources.Load<GameObject>("Assets/Map/GameObjects/OutsideWall");
                }
                if (map[i, j] == 3){
                    GameObject OutsideCorner = Resources.Load<GameObject>("Assets/Map/GameObjects/InsideCorner");
                }
                if (map[i, j] == 4){
                    GameObject OutsideCorner = Resources.Load<GameObject>("Assets/Map/GameObjects/InsideWall");
                }
                if (map[i, j] == 5){
                    GameObject OutsideCorner = Resources.Load<GameObject>("Assets/Map/GameObjects/Pellet");
                }
                if (map[i, j] == 6){
                    GameObject OutsideCorner = Resources.Load<GameObject>("Assets/Map/GameObjects/PowerPellet");
                }
                if (map[i, j] == 7){
                    GameObject OutsideCorner = Resources.Load<GameObject>("Assets/Map/GameObjects/T-Junction");
                }
            }
        }
    }
}
