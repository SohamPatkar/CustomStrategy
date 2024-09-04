using UnityEngine;

public class InputScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Vector3 _destination;
    public CubeCoordinates _check;
    public bool _move;
    // Start is called before the first frame update
    void Start()
    {
        _destination = _player.transform.position;
        _move = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitinfo = hit.collider.gameObject;
            CubeLocation Location = hitinfo.GetComponent<CubeLocation>();
            if (Input.GetMouseButton(0))
            {
                TravelToPoint(Location.LocationX, Location.LocationY);
            }
        }
        MoveTo(_destination);
    }

    void TravelToPoint(float x, float z)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= z; j++)
            {
                _destination = new Vector3(i, 1, j);
            }
        }
    }

    void MoveTo(Vector3 destination)
    {
        _player.transform.position = Vector3.MoveTowards(_player.transform.position, destination, 2f * Time.deltaTime);
    }
}

//Code to be executed
// foreach (var cube in _genScript._cubesGenerated)
// {
//     if (cube.transform.position == new Vector3(i, 0, j))
//     {
//         if (!(cube.GetComponent<MeshRenderer>().material.color == Color.red))
//         {
//             _destination = new Vector3(i, 1, j);
//         }
//         else
//         {
//             break;
//         }
//     }
// }