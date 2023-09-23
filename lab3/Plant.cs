namespace lab3;


    public abstract record Plant
    {
        private string _ShortName;
        public string ShortName
        {
            get { return _ShortName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AggregateException("Введіть шось неможна залишати порожнім");
                _ShortName = value;
            }
        }
        private string _FullName;
        public string FullName
        {
            get { return _FullName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AggregateException("Введіть шось неможна залишати порожнім");
                _FullName = value;
            }
        }
        
        private int _GrowingTime;
        public int GrowingTime
        {
            get { return _GrowingTime; }
            set
            {
                if (0 >= value)
                    throw new AggregateException("Введіть шось неможна залишати порожнім");
                _GrowingTime = value;
            }
        }
        
      
        public bool IsNeedRegrow { get; set; }

        protected Plant(string shortName, string fullName, int growingTime, bool isNeedRegrow)
        {
            ShortName = shortName;
            FullName = fullName;
            GrowingTime = growingTime;
            IsNeedRegrow = isNeedRegrow;

        }
        // public static Plant CreatePlant(string shortName, string fullName, int growingTime, bool isNeedRegrow)
        // {
        //     return new Plant(shortName, fullName, growingTime, isNeedRegrow);
        // }
        public event EventHandler<PlantGrownEventArgs>? PlantGrown;
        
        internal virtual void OnPlantGrown()
        {
            PlantGrown?.Invoke(this, new PlantGrownEventArgs(this));
        }

    }
public record Carrot : Plant
{
    
    public Carrot(string shortName, string fullName, int growingTime, bool isNeedRegrow)
        : base(shortName, fullName, growingTime, isNeedRegrow)
    {
        
    }
}

public record Potato : Plant
{
    
    public Potato(string shortName, string fullName, int growingTime, bool isNeedRegrow)
        : base(shortName, fullName, growingTime, isNeedRegrow)
    {
        
    }
}

public record TavKakomMestePLantCeZapuc : Plant
{
    
    public TavKakomMestePLantCeZapuc(string shortName, string fullName, int growingTime, bool isNeedRegrow)
        : base(shortName, fullName, growingTime, isNeedRegrow)
    {
        
    }
}    
