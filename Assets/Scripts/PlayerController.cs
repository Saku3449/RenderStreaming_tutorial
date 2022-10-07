using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Unity.RenderStreaming;

public class PlayerController : MonoBehaviour
{
    //public Text urlText_1;
    //public Text urlText_2;
    //public Text urlText_3;

    private void Awake()
    {
        //var args = System.Environment.GetCommandLineArgs();

        //urlText_1.text = args[0];
        //urlText_2.text = args[1];
        //urlText_3.text = args[2];

        //RenderStreaming renderStreaming = GetComponent<RenderStreaming>();
        //renderStreaming.urlSignaling = args[1];
    }    

    public void Look(InputAction.CallbackContext value)
    {
        Vector2 input = value.ReadValue<Vector2>();
        transform.eulerAngles += new Vector3(-input.y, input.x, 0);
    }
}