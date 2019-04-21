using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    private string beforeSceneName;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void PushButton(string name) {
        UnloadScene(name);
        SceneManager.LoadScene("Scene" + name, LoadSceneMode.Additive);
    }

    public void UnloadScene(string name) {
        if (!string.IsNullOrEmpty(this.beforeSceneName)) {
            SceneManager.UnloadSceneAsync("Scene" + beforeSceneName);
        }
        this.beforeSceneName = name;
    }
}
