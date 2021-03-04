namespace Dss.CoreShared
{
    public interface ICrypto
    {
        string DecryptString(string text, ICrpytoParams crpytoParams);

        string EncryptString(string text, ICrpytoParams crpytoParams);
    }
}