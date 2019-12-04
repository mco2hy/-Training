namespace Data
{
    public abstract class Araba
    {
        public int LastikSayisi { get; set; }
        public int KapiSayisi { get; set; }
        public int HorsePower { get; set; }
        public int Tork { get; set; }
        public int Agirlik { get; set; }
    }

    public class ArabaV2 : Araba                            //ArabaV2 is a Araba -- ArabaV2 bir Araba'dır.
    {
        public bool UcuyorMu { get; set; }
    }

    public class ArabaV3 : ArabaV2
    {
        public bool IsinlaniyorMu { get; set; }
    }

    public class ArabaV4 : ArabaV3
    {
        public bool YoktanVarOluyorMu { get; set; }
    }

    public class Ferrari : ArabaV2 , IDrive
    {
        public bool TersUcabiliyorMu { get; set; }

        public void Ileri()
        {
            throw new System.NotImplementedException();
        }

        public void Geri()
        {
            throw new System.NotImplementedException();
        }

        public void Sag()
        {
            throw new System.NotImplementedException();
        }

        public void Sol()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IDrive
    {
        void Ileri();
        void Geri();
        void Sag();
        void Sol();
    }

}
