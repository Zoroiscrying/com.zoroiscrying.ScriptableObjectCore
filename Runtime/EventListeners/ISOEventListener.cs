namespace com.zoroiscrying.ScriptableObjectCore
{
    public interface ISOEventListener
    {
        void OnEventRaised();
    }
    
    //DT for data type.
    public interface ISOEventListener<TD>
    {
        void OnEventRaised(TD data);
    }
}
