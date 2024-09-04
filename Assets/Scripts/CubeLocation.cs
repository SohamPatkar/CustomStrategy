using UnityEngine;

public class CubeLocation : MonoBehaviour
{
    public float LocationX, LocationY;
    public MeshRenderer _cubMaterial;
    // Start is called before the first frame update
    void Start()
    {
        _cubMaterial = gameObject.GetComponent<MeshRenderer>();
        LocationX = transform.position.x;
        LocationY = transform.position.z;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            _cubMaterial.material.SetColor("_Color", Color.red);
        }
    }
}
