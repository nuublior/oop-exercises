namespace _26._1_DynamicArray;

using System;
using System.Text;

public class DynArray<T> : IDynArray<T>
{
    private T[] _data;
    private int _capacity;
    private int _fill;

    public DynArray()
    {
        _capacity = 10; // Starting capacity
        _data = new T[_capacity];
        _fill = 0;
    }

    public void Append(T element)
    {
        if (_fill == _capacity)
        {
            Resize(_capacity * 2); // Double the capacity if array is full
        }
        _data[_fill++] = element;
    }

    public void Insert(int i, T element)
    {
        if (i < 0 || i > _fill) throw new ArgumentOutOfRangeException();
        if (_fill == _capacity)
        {
            Resize(_capacity * 2);
        }
        for (int j = _fill; j > i; j--)
        {
            _data[j] = _data[j - 1];
        }
        _data[i] = element;
        _fill++;
    }

    public void Remove(int i)
    {
        if (i < 0 || i >= _fill) throw new ArgumentOutOfRangeException();
        for (int j = i; j < _fill - 1; j++)
        {
            _data[j] = _data[j + 1];
        }
        _fill--;
        if (_fill < _capacity / 2)
        {
            Resize(_capacity / 2);
        }
    }

    public void Set(int i, T element)
    {
        if (i < 0 || i >= _fill) throw new ArgumentOutOfRangeException();
        _data[i] = element;
    }

    public T Get(int i)
    {
        if (i < 0 || i >= _fill) throw new ArgumentOutOfRangeException();
        return _data[i];
    }

    public int GetFill()
    {
        return _fill;
    }

    private void Resize(int newCapacity)
    {
        T[] newData = new T[newCapacity];
        for (int i = 0; i < _fill; i++)
        {
            newData[i] = _data[i];
        }
        _data = newData;
        _capacity = newCapacity;
    }

    public override string ToString()
    {
        var elements = new StringBuilder();
        elements.Append("[ ");
        for (int i = 0; i < _fill; i++)
        {
            elements.Append(_data[i] + " ");
        }
        elements.Append("]");
        return elements.ToString();
    }
}
