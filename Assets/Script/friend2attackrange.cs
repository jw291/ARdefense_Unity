using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friend2attackrange : MonoBehaviour {
	public GameObject f2attackrange;
    public GameObject f2attackpoint;
    public GameObject f2parent;

    public static GameObject f2instantiateattackrange;


    public void Enable()
    {
        f2instantiateattackrange = Instantiate(f2attackrange, f2attackpoint.transform.position, f2attackpoint.transform.rotation) as GameObject;
        f2instantiateattackrange.transform.SetParent(f2parent.transform);
    }
    public void Disable()
    {
        Destroy(f2instantiateattackrange);
    }
}
