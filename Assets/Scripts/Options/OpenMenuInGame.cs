using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenuInGame : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _settingsPanel;

    private string _sceneName;
    private bool _canOpenMenu;

    private void Start()
    {
        _canOpenMenu = true;
        _menuPanel.SetActive(false);
        Cursor.visible = true;
        _sceneName = SceneManager.GetActiveScene().name;
        // Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (_canOpenMenu)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!_menuPanel.activeSelf)
                {
                    _menuPanel.SetActive(true);
                    Time.timeScale = 0;
                }
                else
                {
                    if (_settingsPanel.activeSelf)
                        _settingsPanel.SetActive(false);

                    _menuPanel.SetActive(false);
                    Time.timeScale = 1;
                }
            }
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(_sceneName);
        Time.timeScale = 1;
    }

    public void Continue()
    {
        _menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void CanOpenMenu()
    {
        _canOpenMenu = false;
    }
}
