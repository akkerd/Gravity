using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GravityFlip : MonoBehaviour {

    private GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        player = other.gameObject;
        Debug.Log(player.GetComponent<Rigidbody2D>().gravityScale);

        player.GetComponent<Rigidbody2D>().gravityScale *= -1;
        player.transform.Rotate( 0f, 180f, 180f, Space.World);

        player.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_JumpForce *= -1;
        UnableFor(2f);

    }

    IEnumerator UnableFor( float sec )
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(sec);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
