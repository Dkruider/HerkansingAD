namespace Huiswerk4
{
    public interface IFCNSNode<T>
    {
        T GetData();
        FCNSNode<T> GetFirstChild();
        FCNSNode<T> GetNextSibling();
    }
}