using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

    public Animator animator;

    public GameObject scope;

    public GameObject wepCamera;
    public Camera mainCamera;
    public float scopedFOV = 15f;
    private float normalFOV;
    public bool isScoped = false;

    void Update()
    {
		if(Input.GetButtonDown("Fire2"))
        {
            isScoped = !isScoped;
            animator.SetBool("IsScoped", isScoped);

            scope.SetActive(isScoped);

            if (isScoped)
            {
                StartCoroutine(OnScoped());
            }
            else
                OnUnscoped();
        }
    }



	void OnUnscoped()
    {
	    scope.SetActive(false);
        wepCamera.SetActive(true);

        mainCamera.fieldOfView = normalFOV;
    }
		

    IEnumerator OnScoped()
    {
        yield return new WaitForSeconds(.15f);

        scope.SetActive(true);
        wepCamera.SetActive(false);

        normalFOV = mainCamera.fieldOfView;
        mainCamera.fieldOfView = scopedFOV;
    }

}
