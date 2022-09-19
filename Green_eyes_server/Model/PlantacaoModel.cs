namespace Green_eyes_server.Model
{
    public class PlantacaoModel:PadraoModel
    {
        public PlantacaoModel()
        {
            this.GenerateID();
        }
        public string? plantacao { get; set; }
    }
}
