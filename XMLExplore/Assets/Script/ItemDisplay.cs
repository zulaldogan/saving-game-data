using UnityEngine;

public class ItemDisplay : MonoBehaviour
{
    public ItemBlock blockPrefab;

    void Start()
    {
        Display();
    }

    public void Display()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        foreach (ItemEntry item in XMLManager.ins.itemDB.list)
        {
            ItemBlock newBlock = Instantiate(blockPrefab) as ItemBlock;
            newBlock.transform.SetParent(transform, false);
            newBlock.Display(item);
        }
    }
}
