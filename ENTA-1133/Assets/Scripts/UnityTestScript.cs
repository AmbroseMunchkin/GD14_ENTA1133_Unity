using UnityEngine;

public class UnityTestScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start normal log");
        Debug.LogWarning("Stat warning log");
        Debug.LogError("Start error log");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update normal log");
    }
}
