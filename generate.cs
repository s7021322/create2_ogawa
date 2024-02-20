using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;

    [SerializeField]
    private Transform root;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GenerateCube();
        }
    }

    private void GenerateCube()
    {
        var cube = Instantiate(cubePrefab, root);
        cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);

    }
}