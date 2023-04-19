namespace WeatherApp
{
    class преподаватель
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public преподаватель(string name)
        {
            _name = name;
        }
    }
}
