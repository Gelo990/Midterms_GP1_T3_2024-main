using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject henPrefab;
    public GameObject roosterPrefab;

    void Start()
    {
        StartCoroutine(Grow());
    }

    IEnumerator Grow()
    {
        yield return new WaitForSeconds(10f);
        if (Random.value > 0.5f)
        {
            GameObject hen = Instantiate(henPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);  // Destroy the chick
        }
        else
        {
            GameObject rooster = Instantiate(roosterPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);  // Destroy the chick
        }
    }
}
