using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {

    private Camera main;

	// Use this for initialization
	void Start () {
        main = this.GetComponent<Camera>();
	}

    private SwordSelected select;
	// Update is called once per frame
	void Update () {
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        ray = main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)){
            SwordSelected tmp = hit.transform.gameObject.GetComponent<SwordSelected>();

            if (select)
            {
                if (tmp)
                {
                    if (tmp.gameObject.GetInstanceID() != select.gameObject.GetInstanceID())
                    {
                        select.Untouched();
                        select = tmp;
                        if (GvrControllerInput.ClickButtonDown)
                        {
                            
                        }
                    }
                }
                else{
                    select.Untouched();
                    select = null;
                }
            }
            else{
                select = tmp;
            }

            if(select){
                select.Touched();
            }
            else{
                if(select){
                    select.Untouched();
                    select = null;
                }
            }
            
        }
        else{
            if (select)
            {
                select.Untouched();
                select = null;
            }
        }
	}
}
