using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public EnemyData data;

    float timer;
    bool moveLeft = false;

    void Start()
    {
        gameObject.name = data.name;
        timer = data.moveTime;
        GetComponent<SpriteRenderer>().color = data.color;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Move();
            timer += data.moveTime;
        }
    }

    void Move()
    {
        if (!moveLeft)
        {
            transform.position += Vector3.right;
        }
        else
        {
            transform.position += Vector3.left;
        }
        if (Mathf.Abs(transform.position.x) >= data.limit)
        {
            moveLeft = !moveLeft;
        }
    }
}
