using UnityEngine;

public class GenericExample01 : MonoBehaviour
{
    private DataStorage<string> _stringDataStorage;
    private DataStorage<int> _intDataStorage;

    // Start is called before the first frame update
    void Start()
    {
        _stringDataStorage = new DataStorage<string>();
        _stringDataStorage.Data = "Hello World!!";
        Debug.Log("string : " + _stringDataStorage.Data);


        _intDataStorage = new DataStorage<int>();
        _intDataStorage.AddData(3);
        Debug.Log("int : " + _intDataStorage.Data);
    }
}

public class DataStorage<T>
{
    public T Data;

    public void AddData(T data)
    {
        Data = data;
    }
}