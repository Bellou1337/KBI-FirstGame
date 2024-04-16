
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public int max_result;
        public float Volume;
        public float Sensor;

        public SavesYG()
        {
            Sensor = 2;
            Volume = 7;
            max_result = 0;
        }
    }
}
