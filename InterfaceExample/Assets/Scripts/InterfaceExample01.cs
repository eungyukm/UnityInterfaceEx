using UnityEngine;

public class InterfaceExample01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hydralisk hydralisk = new Hydralisk();
        hydralisk.Burrow();
        hydralisk.RecoveryHp();
        // Log
        // 땅속에 숨습니다.
        // 체력을 재생합니다.

        IZerg iZerg = new Hydralisk(); // iZerg는 히드라리스크의 인스턴스
        iZerg.Burrow();
        iZerg.RecoveryHp();
        // Log
        // 땅속에 숨습니다.
        // 체력을 재생합니다.
    }
}

interface IZerg
{
    // 접근 제한자를 사용할 수 없습니다.
    void RecoveryHp();
    void Burrow();
}

// 파생 클래스에서는 반드시 인터페이스에서 정의된 메서드를 구현해야 합니다.
class Hydralisk : IZerg, IMetamorph
{
    public void Burrow()
    {
        Debug.Log("땅속에 숨습니다");
    }

    public void RecoveryHp()
    {
        Debug.Log("체력을 재생합니다.");
    }

    public void Morph(string name)
    {
        Debug.Log("변형 됩니다.");
    }
}

interface IMetamorph
{
    void Morph(string name); // 변형 ex) 드론 -> 저글링, 히드라리스크 -> 러커
}