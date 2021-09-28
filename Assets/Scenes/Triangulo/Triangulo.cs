using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{
    Mesh mesh;
    MeshRenderer meshRenderer;
    Vector3[] vertices;
    int[] triangulo;
    // Start is called before the first frame update
    public Material material;

    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        vertices = new[]{
            new Vector3(0,0),
            new Vector3(0,1),
            new Vector3(1,0)
        };
        mesh.vertices = vertices;
        triangulo = new [] { 0, 1, 2 };

        mesh.triangles = triangulo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
