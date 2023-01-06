using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkingController : MonoBehaviour
{
    public Mesh FilledGlassMesh;
    public Material[] FilledGlassMaterials;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillWithPotion()
    {
        Debug.Log("Filling a glass with potion.");

        // Replace mesh with filled beaker
        MeshFilter MeshFilter = GetComponent<MeshFilter>();
        MeshFilter.mesh = FilledGlassMesh;

        MeshRenderer MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.materials = FilledGlassMaterials;

    }
}
