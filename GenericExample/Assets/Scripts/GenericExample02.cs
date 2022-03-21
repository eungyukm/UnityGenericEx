using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ItemFactory<int> itemFactory = new ItemFactory<int>();
        itemFactory.item = 1;
        Debug.Log( itemFactory.GetNewItem() );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// where ������ ������ ���� ������ ���Ե� �� �ֽ��ϴ�.
// new ���� ������ ���׸� Ŭ���� ������ ���� �μ��� ���� �Ű������� ���� �����ڰ� �־�� ��
public class Generic01<T> where T : new()
{
    T item = new T();
}

public class ItemFactory<T> where T : new()
{
    public T item = new T();
    public T GetNewItem()
    {
        return new T();
    }
}
