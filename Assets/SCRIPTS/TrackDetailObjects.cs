using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrackDetailObjects : MonoBehaviour
{
    public List<GameObject> detailObjects = new List<GameObject>();//fill t$$anonymous$$s list via the inspector or via script with the region name objects

    public float detailThreshold = 50f;

    void Update()
    {
        CheckDistances();
    }

    private void CheckDistances()
    {
        foreach (GameObject go in detailObjects)
        {
            float distance = Vector3.Distance(transform.position, go.transform.position);
            if (distance < detailThreshold)
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null && renderer.enabled == false)
                {
                    renderer.enabled = true;
                }
            }
            else
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null && renderer.enabled == true)
                {
                    renderer.enabled = false;
                }
            }
        }
    }
}