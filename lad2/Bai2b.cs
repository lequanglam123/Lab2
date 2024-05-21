using System; // Thêm câu lệnh này để sử dụng namespace System

public void Bai1b()
{
    int y = 10;
    Action<int> AnonymousMethod = delegate (int x) // Sửa Action để chấp nhận tham số kiểu int
    {
        int sum = x + y;
        int sub = sum - y;
        UnityEngine.Debug.Log("sum: " + sum);
        UnityEngine.Debug.Log("sub: " + sub);
    };
    AnonymousMethod(5);
}