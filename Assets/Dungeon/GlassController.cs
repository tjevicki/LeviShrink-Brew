using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassController : MonoBehaviour
{
    public Mesh EmptyGlassMesh;
    public Material[] EmptyGlassMaterials;

    public Mesh FilledGlassMesh;
    public Material[] FilledGlassMaterials;

    public Potion potion { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillWithPotion(Potion potion)
    {
        Debug.Log("Filling a glass with potion.");

        this.potion = potion;

        MeshFilter MeshFilter = GetComponent<MeshFilter>();
        MeshFilter.mesh = FilledGlassMesh;

        MeshRenderer MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.materials = FilledGlassMaterials;

    }

    public void Empty()
    {
        this.potion = null;

        MeshFilter MeshFilter = GetComponent<MeshFilter>();
        MeshFilter.mesh = EmptyGlassMesh;

        MeshRenderer MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.materials = EmptyGlassMaterials;
    }
}
