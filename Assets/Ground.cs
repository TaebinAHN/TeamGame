using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    //땅 움직이는 속도
    public float bgSpeed = 1f;
    float move;

    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        move += Time.deltaTime * bgSpeed;
        renderer.material.mainTextureOffset = new Vector2(move, 0);
    }
}
