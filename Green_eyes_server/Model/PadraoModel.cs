namespace Green_eyes_server.Model
{
    public class PadraoModel
    {
        public PadraoModel()
        {
            GenerateID();
        }
        public virtual string id { get; set; }

        public virtual bool Ativado { get; set; }

        public void GenerateID()
        {
            byte[] randomByte = new byte[16];

            new Random().NextBytes(randomByte);

            Guid mGuid = new Guid(randomByte);

            id = mGuid.ToString();
        }
    }
}
