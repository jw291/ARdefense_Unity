using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friend3attackrange : MonoBehaviour {

	public GameObject f3attackrange;
    public GameObject f3attackpoint;
    public GameObject f3parent;

    public static GameObject f3instantiateattackrange;


    public void Enable()
    {
        f3instantiateattackrange = Instantiate(f3attackrange, f3attackpoint.transform.position, f3attackpoint.transform.rotation) as GameObject;
        f3instantiateattackrange.transform.SetParent(f3parent.transform);
    }
    public void Disable()
    {
        Destroy(f3instantiateattackrange);
    }
}
