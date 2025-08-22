using UnityEngine;

public class TrashButton : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        target = GameObject.Find("TrashParent");
    }
    public void ObjChange()
    {
        target.SetActive(true);
    }
}
