using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject chickPrefab;

    void Start()
    {
        StartCoroutine(Hatch());
    }
    
    IEnumerator Hatch()
    {
       yield return new WaitForSeconds(10f);
       GameObject chick = Instantiate(chickPrefab, transform.position, Quaternion.identity);
       Destroy(gameObject);  // Destroy the egg
    }   
}
