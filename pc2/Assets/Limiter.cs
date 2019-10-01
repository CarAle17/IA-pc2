using UnityEngine;

public class Limiter : MonoBehaviour
{
    [Range(1, 20)]
    [SerializeField]
    private int SizeY = 5;
    private float SizeX;

    [SerializeField]
    private Transform Target;
    [SerializeField]
    private Transform Follower;

    private void Awake()
    {
        SizeX = SizeY * (16f / 9f);
    }

    private void Update()
    {
        //Otra opcion de rectangulo oculto en unity

        Follower.position = new Vector3(
            Mathf.Clamp(Target.position.x, -SizeX, SizeX),
            Mathf.Clamp(Target.position.y, -SizeY, SizeY),
            -10);
    }

    private void OnDrawGizmos()
    {
        float h = SizeY * 2;
        float w = h * (16f / 9f);
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(transform.position, new Vector3(w, h));
    }
}
