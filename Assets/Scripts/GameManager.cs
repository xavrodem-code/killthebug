using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _nextSceneToLoad;
    private bool _isLevelEnd;
    // Start is called before the first frame update
    void Start()
    {
        _nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isLevelEnd == true)
        {

            SceneManager.LoadScene(_nextSceneToLoad);
        }
        else if (SceneManager.GetActiveScene().buildIndex + 1 == 3)
        {
            _isLevelEnd = false;
        }
    }

    public void NextLevel()
    {
        _isLevelEnd = true;
    }
}
