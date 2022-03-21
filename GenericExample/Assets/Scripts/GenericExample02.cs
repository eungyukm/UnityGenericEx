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

// where 절에는 생성자 제약 조건이 포함될 수 있습니다.
// new 제약 조건은 제네릭 클래스 선언의 형식 인수에 공용 매개변수가 없는 생성자가 있어야 함
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
