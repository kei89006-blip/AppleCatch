using UnityEngine;
using UnityEngine.InputSystem;//入力を検知するために必要！！

public class BasketController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate =60;
    }
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray =Camera.main.ScreenPointToRay(
                Mouse.current.position.value);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.x);
                transform.position = new Vector3(x, 0, z);
            }

            
        }       
    }
}
