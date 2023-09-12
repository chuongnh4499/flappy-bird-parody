using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }
    protected bool isClickedMouseLeft = false;
    public bool IsClickedMouseLeft { get => isClickedMouseLeft; set => isClickedMouseLeft = value; }
    protected bool isPressSpace = false;
    public bool IsPressSpace { get => isPressSpace; set => isPressSpace = value; }

    void Awake()
    {
        if (instance != null) Debug.LogError("Only one InputManager allow to exist");
        instance = this;
    }

    void Update()
    {
        SettingInputPC();
    }

    void SettingInputPC()
    {
        if (GameManager.Instance.GetStatusGame() == Status.PLAY) {
            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()) isClickedMouseLeft = true;
            if (Input.GetKey(KeyCode.Space)) isPressSpace = true;
        }
    }

    void SettingInputMobile() { }
}
