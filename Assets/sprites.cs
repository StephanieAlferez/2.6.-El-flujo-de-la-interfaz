using UnityEngine;
using UnityEngine.EventSystems;

public class sprites : MonoBehaviour, IDragHandler
{
    public float z = 0.0f;
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = z;

        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}
