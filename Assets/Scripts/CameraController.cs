using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Camera DisposeCamera;
    private Canvas _canvas;


    // Start is called before the first frame update
    void Start() {
        this._canvas = this.GetComponent<Canvas>();

        if (Camera.main != null
            && this.DisposeCamera != null
            && !Object.ReferenceEquals(this.DisposeCamera, Camera.main)) {

            this._canvas.worldCamera = Camera.main;
            Destroy(this.DisposeCamera.gameObject);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
