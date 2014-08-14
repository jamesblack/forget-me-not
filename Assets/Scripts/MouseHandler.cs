using UnityEngine;
using System.Collections;

public class MouseHandler : MonoBehaviour
{

    public Survivor Selected;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
	    {
	        Debug.Log("Click Detected");

	        RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);

            if (hitInfo && hitInfo.transform.gameObject.GetComponent<Entity>())
	        {
	            Entity target = hitInfo.transform.gameObject.GetComponent<Entity>();

	            if (target is Survivor)
	            {
	                Survivor survivor = target as Survivor;
                    if (Selected == survivor)
                    {
                        Debug.Log("You Already Selected this Fool");
                        return;
                    }

                    Debug.Log("You selected " + survivor.FullName);
                    Selected = survivor;
                }
                else if (target is Zombie)
                {
                    Debug.Log("Stop Clicking Zombies you fool!");    
                }
	        }
	        else
	        {
	            Selected = null;
	        }
	    }
	}
}
