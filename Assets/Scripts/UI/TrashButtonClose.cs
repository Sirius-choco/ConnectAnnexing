using UnityEngine;

public class TrashButtonClose : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject target;

    void Start()
    {
        target = GameObject.Find ("TrashParent");
    }
    public void ObjChange()
    {
        target.SetActive(false);
    }
}
