using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassController : MonoBehaviour
{
    public Mesh EmptyGlassMesh;
    public Material[] EmptyGlassMaterials;

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

        MeshFilter MeshFilter = GetComponent<MeshFilter>();
        MeshFilter.mesh = FilledGlassMesh;

        MeshRenderer MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.materials = FilledGlassMaterials;

    }

    public void Empty()
    {
        MeshFilter MeshFilter = GetComponent<MeshFilter>();
        MeshFilter.mesh = EmptyGlassMesh;

        MeshRenderer MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.materials = EmptyGlassMaterials;
    }
}
