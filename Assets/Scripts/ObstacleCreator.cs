using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;
    [SerializeField] private CubeCoordinates _cubeCoordinates;
    private float _currentxCoordinate, _currentzCoordinate;
    // Start is called before the first frame update
    void Start()
    {
        _currentxCoordinate = _cubeCoordinates._xCoordinate;
        _currentzCoordinate = _cubeCoordinates._zCoordinate;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(_cubeCoordinates._xCoordinate == _currentxCoordinate && _cubeCoordinates._zCoordinate == _currentzCoordinate))
        {
            Instantiate(_obstacle, new Vector3(_cubeCoordinates._xCoordinate, 1, _cubeCoordinates._zCoordinate), Quaternion.identity);
            _currentxCoordinate = _cubeCoordinates._xCoordinate;
            _currentzCoordinate = _cubeCoordinates._zCoordinate;
        }
    }
}
