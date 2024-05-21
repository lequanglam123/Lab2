using System; // Thêm câu lệnh này để sử dụng namespace System
public void Bai1a()
{
    var userInfo = new { id = "2024", name = "faker", isPlaying = false, bag = new { skins = 0, cups = 20 } };
    UnityEngine.Debug.Log("id: " + userInfo.id); // Sử dụng UnityEngine.Debug.Log thay vì Debug.Log
    UnityEngine.Debug.Log("name: " + userInfo.name);
    UnityEngine.Debug.Log("isplaying: " + userInfo.isPlaying);
    UnityEngine.Debug.Log("bag skins: " + userInfo.bag.skins);
    UnityEngine.Debug.Log("bag cups: " + userInfo.bag.cups);
}