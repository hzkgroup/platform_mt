using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform leftPoint;
    public Transform rightPoint;
    public float speed = 2f;
    private bool movingRight = true;

    private void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= rightPoint.position.x)
                movingRight = false;
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x <= leftPoint.position.x)
                movingRight = true;
        }
        transform.localScale = new Vector3(movingRight ? 1 : -1, 1, 1);
    }

    // (опционально) отобразим гизмы в редакторе
    private void OnDrawGizmos()
    {
        if (leftPoint != null && rightPoint != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(leftPoint.position, rightPoint.position);
        }
    }
}