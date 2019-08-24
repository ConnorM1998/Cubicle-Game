using UnityEngine;

public class followPlayer : MonoBehaviour {

    //
    public Transform player;
    //Stores 3 Floats
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
		
	}
}
