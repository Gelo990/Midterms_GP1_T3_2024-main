using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
   public GameObject EggPrefab;
    void Start()
    {
        StartCoroutine(LayEggs());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LayEggs()
    {
        yield return new WaitForSeconds(1); 
      int random = Random.Range(2,9);
      for (int i = 0; i < random; i++ )  
      {
        Instantiate(EggPrefab);
      }
    }
}
