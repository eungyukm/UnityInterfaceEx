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
        // ���ӿ� �����ϴ�.
        // ü���� ����մϴ�.

        IZerg iZerg = new Hydralisk(); // iZerg�� ����󸮽�ũ�� �ν��Ͻ�
        iZerg.Burrow();
        iZerg.RecoveryHp();
        // Log
        // ���ӿ� �����ϴ�.
        // ü���� ����մϴ�.
    }
}

interface IZerg
{
    // ���� �����ڸ� ����� �� �����ϴ�.
    void RecoveryHp();
    void Burrow();
}

// �Ļ� Ŭ���������� �ݵ�� �������̽����� ���ǵ� �޼��带 �����ؾ� �մϴ�.
class Hydralisk : IZerg, IMetamorph
{
    public void Burrow()
    {
        Debug.Log("���ӿ� �����ϴ�");
    }

    public void RecoveryHp()
    {
        Debug.Log("ü���� ����մϴ�.");
    }

    public void Morph(string name)
    {
        Debug.Log("���� �˴ϴ�.");
    }
}

interface IMetamorph
{
    void Morph(string name); // ���� ex) ��� -> ���۸�, ����󸮽�ũ -> ��Ŀ
}